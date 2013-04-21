using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Experiment_03_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //为操作按钮绑定相应的点击事件
            foreach (Control control in btnGroupBox.Controls)
            {
                if (control is Button) control.Click += new EventHandler(ButtonClick);
            }
        }       
               
        #region 按钮事件
        /// <summary>
        /// 除了“计算“按钮之外的按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClick(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btn = sender as Button;
                if (btn == btn0 || btn == btn1 || btn == btn2 || btn == btn3 || btn == btn4 || btn == btn5 ||
                    btn == btn6 || btn == btn7 || btn == btn8 || btn == btn9 || btn == btn0 || btn == btnDot
                    || btn == btnAdd || btn == btnSub || btn == btnMul || btn == btnDiv || btn == btnLeftBracket
                    || btn == btnRightBracket||btn==btnMod)
                {
                    if (txtBoxInput.SelectedText.Length == 0)
                    {
                        txtBoxInput.Text += btn.Text;
                    }
                    else
                    {
                        txtBoxInput.Text = txtBoxInput.Text.Substring(0, txtBoxInput.SelectionStart) + btn.Text
                            + txtBoxInput.Text.Substring(txtBoxInput.SelectionStart + txtBoxInput.SelectedText.Length);
                    }
                }
                else if (btn == btnPow)
                {
                    if (txtBoxInput.SelectedText.Length == 0)
                    {
                        txtBoxInput.Text += '^';
                    }
                    else
                    {
                        txtBoxInput.Text = txtBoxInput.Text.Substring(0, txtBoxInput.SelectionStart) + '^'
                            + txtBoxInput.Text.Substring(txtBoxInput.SelectionStart + txtBoxInput.SelectedText.Length);
                    }
                }               
                else if (btn == btnSin || btn == btnCos || btn == btnTg || btn == btnLn || btn == btnSqrt)
                {
                    if (txtBoxInput.SelectedText.Length == 0)
                    {
                        txtBoxInput.Text += btn.Text;
                    }
                    else
                    {
                        txtBoxInput.Text = txtBoxInput.Text.Substring(0, txtBoxInput.SelectionStart) + btn.Text + "(" + txtBoxInput.SelectedText + ")"
                           + txtBoxInput.Text.Substring(txtBoxInput.SelectionStart + txtBoxInput.SelectedText.Length);
                    }
                }
                else if (btn == btnClear)
                {
                    txtBoxInput.Clear();
                }
                else if (btn == btnBack)
                {
                    if(txtBoxInput.Text.Length>0)
                    txtBoxInput.Text = txtBoxInput.Text.Substring(0, txtBoxInput.TextLength - 1);
                }
                else if (btn == btnSpace)
                {
                    txtBoxInput.Text += " ";
                }
            }
        }

        /// <summary>
        /// “计算“按钮的按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double result;
            string[] strChanged = Change(txtBoxInput.Text);
            if (strChanged == null || strChanged.Length == 0)
            {
                MessageBox.Show("错误");
                txtBoxResult.Text = "0";
                return;
            }
            Calculate(strChanged, out result);
            txtBoxResult.Text = result.ToString();
        }
        #endregion

        #region 用逆波兰式处理串

        /// <summary>
        /// 优先级处理
        /// </summary>
        /// <param name="sign">运算符（为了兼容函数使用字符串）</param>
        /// <returns></returns>
        private int Precedence(string sign)
        {
            switch (sign)
            {
                case "+":
                case "-":
                    return 1;
                case "*":
                case "/":
                    return 2;
                case "%":
                case "^":
                case "!":
                    return 3;
                case "sin":
                case "cos":
                case "tg":
                case "ln":
                case "sqrt":
                    return 4;
                case "#":
                default:
                    return 0;
            }
        }

        /// <summary>
        /// 处理基本的单目双目运算
        /// </summary>
        /// <param name="a">第一运算数</param>
        /// <param name="ch">运算符</param>
        /// <param name="b">第二运算数</param>
        /// <returns></returns>
        private double SimplyCal(double a, string ch, double b = 0)
        {
            switch (ch)
            {
                case "!": return -a;
                case "+": return a + b;
                case "-": return a - b;
                case "*": return a * b;
                case "/": return a / b;
                case "%": return a % b;
                case "^": return Math.Pow(a, b);
                case "sin": return Math.Sin(a);
                case "cos": return Math.Cos(a);
                case "tg": return Math.Tan(a);
                case "ln": return Math.Log(Math.E, a);
                case "sqrt": return Math.Sqrt(a);
                default:
                    return 0;
            }
        }

        /// <summary>
        /// 转换为逆波兰式
        /// </summary>
        /// <param name="source">原串</param>
        /// <returns>逆波兰式串</returns>
        private string[] Change(string source)
        {
            StringBuilder strSource = new StringBuilder(source.Trim());
            Stack<string> stack = new Stack<string>();
            stack.Push("#");
            string[] strTarget = new string[100];
            int count = 0;
            char ch = ' ';

            #region 生成中缀式
            for (int i = 0; i < strSource.Length; )
            {
                ch = strSource[i];
                StringBuilder sb = new StringBuilder();
                if (char.IsDigit(ch) || ch.Equals('.'))
                {
                    while (char.IsDigit(ch) || ch .Equals( '.'))
                    {
                        sb.Append(ch);
                        i++;
                        if (i >= strSource.Length) break;
                        ch = strSource[i];
                    }
                    double tmpValue;
                    if (double.TryParse(sb.ToString(), out tmpValue))
                    {
                        strTarget[count++] = tmpValue.ToString();
                    }
                    else
                    {
                        MessageBox.Show("算式出错(数值)");
                    }
                }
                else if (char.IsLetter(ch))
                {
                    while (char.IsLetter(ch))
                    {
                        sb.Append(ch);
                        i++;
                        if (i >= strSource.Length) break;
                        ch = strSource[i];                        
                    }
                    if (sb.ToString().Equals("sin") || sb.ToString().Equals("cos") || sb.ToString().Equals("tg") || sb.ToString().Equals("ln")
                        || sb.ToString().Equals("sqrt"))
                    {
                        strTarget[count++] = sb.ToString();
                    }
                    else
                    {
                        MessageBox.Show(sb.ToString() + "没有定义");
                    }
                }
                else switch (ch)
                    {
                        case '+':
                            if (!(i == 0 || strTarget[count-1].Equals("(")))
                            {
                                strTarget[count++] = ch.ToString();
                            } 
                            i++;
                            break;
                        case '-':
                        case '*':
                        case '/':
                        case '%':
                        case '^':
                        case '(':
                        case ')':
                            strTarget[count++] = ch.ToString();
                            i++;
                            break;
                        case ' ':
                            i++;
                            break;
                        default:
                            MessageBox.Show(ch + "没有定义");
                            break;
                    }
            }
            for (int i = 0; i < count; i++)
            {
                //-号转义
                if (strTarget[i].Equals("-") && (i == 0||strTarget[i - 1].Equals("(")  ))
                {
                    strTarget[i] = "!";
                } 
            }
            #endregion

            if (Check(strTarget, count) == false)
            {
                return null;
            }

            string[] strResult = new string[count];

            #region 生成逆波兰式
            double tmp;
            int posResult = 0;
            for (int i = 0; i < count; i++)
            {
                if (double.TryParse(strTarget[i], out tmp))
                {
                    strResult[posResult++] = strTarget[i];
                }
                else if (strTarget[i].Equals("("))
                {
                    stack.Push(strTarget[i]);
                }
                else if (strTarget[i].Equals(")"))
                {
                    string strtmp = stack.Pop();
                    while (!strtmp.Equals("("))
                    {
                        strResult[posResult++] = strtmp;
                        strtmp = stack.Pop();
                    }
                    if (stack.Peek().Equals("sin") || stack.Peek().Equals("cos") || stack.Peek().Equals("tg") || stack.Peek().Equals("ln")
                        || stack.Peek().Equals("sqrt"))
                    {
                        strResult[posResult++] = stack.Pop();
                    }
                }
                else if (Precedence(stack.Peek()) < Precedence(strTarget[i]))
                {
                    stack.Push(strTarget[i]);
                }
                else if (Precedence(stack.Peek()) >= Precedence(strTarget[i]))
                {
                    if (!(Precedence(stack.Peek()) == Precedence(strTarget[i]) && Precedence(strTarget[i]) == 4))
                    {
                        strResult[posResult++] = stack.Pop();
                        while (Precedence(stack.Peek()) >= Precedence(strTarget[i]))
                        {
                            strResult[posResult++] = stack.Pop();
                        }
                    }
                    stack.Push(strTarget[i]);
                }
            }
            while (!stack.Peek().Equals("#"))
            {
                strResult[posResult++] = stack.Pop();
            }
            #endregion

            #region 复核逆波兰式到strOutput中并消除后面的null串
            string[] strOutput = new string[posResult];
            for (int i = 0; i < posResult; i++)
            {
                strOutput[i] = strResult[i];
            }
            #endregion

            return strOutput;
        }

        /// <summary>
        /// 计算逆波兰式
        /// </summary>
        /// <param name="source">逆波兰式串</param>
        /// <param name="result">结果</param>
        /// <returns></returns>
        private bool Calculate(string[] source, out double result)
        {
            Stack<string> stack = new Stack<string>();
            result = 0;
            double tmpResult;
            double tmp1, tmp2;
            if (!double.TryParse(source[0], out tmpResult))
            {
                MessageBox.Show("算式出错");
                return false;
            }
            stack.Push(tmpResult.ToString());
            for (int i = 1; i < source.Length; i++)
            {
                if (source[i].Equals("+") || source[i].Equals("-") || source[i].Equals("*") || source[i].Equals("/") || source[i].Equals("%") || source[i].Equals("^"))
                {
                    if (stack.Count < 2)
                    {
                        MessageBox.Show("算式出错");
                        return false;
                    }

                    if (!(double.TryParse(stack.Pop(), out tmp1) && double.TryParse(stack.Pop(), out tmp2)))
                    {
                        MessageBox.Show("算式出错");
                        return false;
                    }
                    tmpResult = SimplyCal(tmp2, source[i], tmp1);
                    stack.Push(tmpResult.ToString());
                }
                else if (source[i].Equals("sin") || source[i].Equals("cos") || source[i].Equals("tg") || source[i].Equals("ln")
                       || source[i].Equals("sqrt") || source[i].Equals("!"))
                {
                    if (stack.Count < 1)
                    {
                        MessageBox.Show("算式出错");
                        return false;
                    }

                    if (!double.TryParse(stack.Pop(), out tmp1))
                    {
                        MessageBox.Show("算式出错");
                        return false;
                    }
                    tmpResult = SimplyCal(tmp1, source[i]);
                    stack.Push(tmpResult.ToString());
                }
                else
                {
                    if (!double.TryParse(source[i], out tmpResult))
                    {
                        MessageBox.Show("算式出错");
                        return false;
                    }
                    stack.Push(tmpResult.ToString());
                }
            }
            if (stack.Count != 1)
            {
                MessageBox.Show("算式出错");
                return false;
            }
            if (!double.TryParse(stack.Pop(), out result))
            {
                MessageBox.Show("算式出错");
                return false;
            }
            return true;

        }

        /// <summary>
        /// 判断中缀表达式是否正确
        /// </summary>
        /// <param name="strTarget"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        bool Check(string[] strTarget, int count)
        {
            double tmpValue;
            int countLeft, countRight, lastLeft, lastRight, firstLeft, firstRight;
            countLeft = countRight = 0;
            firstLeft = firstRight = lastLeft = lastRight = -1;
            for (int i = 0; i < count; i++)
            {
                if (strTarget[i].Equals("("))
                {
                    countLeft++;
                    if (firstLeft == -1) firstLeft = i;
                    lastLeft = i;
                }
                else if (strTarget[i].Equals(")"))
                {
                    if (strTarget[i].Equals("(")) return false;
                    countRight++;
                    if (firstRight == -1) firstRight = i;
                    lastRight = i;
                }
                else if (strTarget[i].Equals("sin") || strTarget[i].Equals("cos") || strTarget[i].Equals("tg") || strTarget[i].Equals("ln")
                       || strTarget[i].Equals("sqrt"))
                {
                    if (!(i != count - 1 && (strTarget[i + 1].Equals("(") || strTarget[i + 1].Equals("sin") || strTarget[i + 1].Equals("cos")
                        || strTarget[i + 1].Equals("tg") || strTarget[i + 1].Equals("ln") || strTarget[i + 1].Equals("sqrt")
                        || double.TryParse(strTarget[i + 1], out tmpValue))))
                    {
                        return false;
                    }
                }
                else if (strTarget[i].Equals("+") || strTarget[i].Equals("-") || strTarget[i].Equals("*") || strTarget[i].Equals("/")
                     || strTarget[i].Equals("^") || strTarget[i].Equals("%"))
                {
                    if (i == 0 || i == count - 1 || strTarget[i + 1].Equals("+") || strTarget[i + 1].Equals("-") ||
                        strTarget[i + 1].Equals("*") || strTarget[i + 1].Equals("/") || strTarget[i + 1].Equals("^") ||
                        strTarget[i + 1].Equals("%") || strTarget[i + 1].Equals(")") || strTarget[i - 1].Equals("+") ||
                        strTarget[i - 1].Equals("-") || strTarget[i - 1].Equals("*") || strTarget[i - 1].Equals("/") ||
                        strTarget[i - 1].Equals("^") || strTarget[i - 1].Equals("%") || strTarget[i - 1].Equals("("))
                    {
                        return false;
                    }
                }
            }
            if (countLeft != countRight||lastLeft>lastRight||firstLeft>firstRight) return false;
            return true;
        }

        #endregion
        

        private void btn_KeyDown(object sender, KeyEventArgs e)
        {
            this.btnCalculate.Focus();
        }

        private void btnCalculate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                if (txtBoxInput.Text.Length > 0)
                    txtBoxInput.Text = txtBoxInput.Text.Substring(0, txtBoxInput.TextLength - 1);
            }
            else
            {
                txtBoxInput.Text += e.KeyChar;
            }
        }
    }

}
