using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtBoxHead.Text = "5";
            txtBoxTail.Text = "11";
            txtBoxNum.Text = "100";
            listBoxOperator.Items.AddRange(new string[] { "+", "-", "*", "/", "Q", "S" });
            listBoxLetter.Items.AddRange(new string[] { "a", "b", "c", "d" });
            listBoxValue.Items.AddRange(new string[] { "1", "2", "3", "4" });
        }
        #region Operator
        private void btnOperatorAdd_Click(object sender, EventArgs e)
        {
            char ch;
            if (!char.TryParse(txtBoxOperator.Text, out ch))
            {
                MessageBox.Show("Is Not Char");
            }
            else
            {
                if (char.IsDigit(ch))
                {
                    MessageBox.Show(ch + " Is a Digit");
                }
                else
                {
                    if (listBoxOperator.Items.Contains(ch.ToString()))
                    {
                        MessageBox.Show("Already have " + ch);
                    }
                    else
                    {
                        listBoxOperator.Items.Add(ch.ToString());
                        txtBoxOperator.Text = "";
                    }
                }
            }

        }

        private void btnOperatorDel_Click(object sender, EventArgs e)
        {
            listBoxOperator.Items.Remove(listBoxOperator.SelectedItem);
        }

        private void btnOperatorDelAll_Click(object sender, EventArgs e)
        {
            listBoxOperator.Items.Clear();
        }
        #endregion

        #region Letter
        private void btnLetterAdd_Click(object sender, EventArgs e)
        {
            char ch;
            if (!char.TryParse(txtBoxLetter.Text, out ch))
            {
                MessageBox.Show("Is Not Char");
            }
            else
            {
                if (char.IsUpper(ch)) ch=char.ToLower(ch);
                
                if (listBoxLetter.Items.Contains(ch.ToString()))
                {
                    MessageBox.Show("Already have " + ch);
                }
                else
                {
                    if (char.IsDigit(ch))
                    {
                        MessageBox.Show(ch + " Is a Digit");
                    }
                    else
                    {
                        listBoxLetter.Items.Add(ch.ToString());
                        txtBoxLetter.Text = "";
                    }
                }
            }
        }

        private void btnLetterDel_Click(object sender, EventArgs e)
        {
            listBoxLetter.Items.Remove(listBoxLetter.SelectedItem);
        }

        private void btnLetterDelAll_Click(object sender, EventArgs e)
        {
            listBoxLetter.Items.Clear();
        }
        #endregion

        #region Value
        private void btnValueAdd_Click(object sender, EventArgs e)
        {
            double dle;
            if (!double.TryParse(txtBoxValue.Text, out dle))
            {
                MessageBox.Show("Is Not Value");
            }
            else
            {
                listBoxValue.Items.Add(dle);
                txtBoxValue.Text = "";
            }
        }

        private void btnValueDel_Click(object sender, EventArgs e)
        {
            listBoxValue.Items.Remove(listBoxValue.SelectedItem);
        }

        private void btnValueDelAll_Click(object sender, EventArgs e)
        {
            listBoxValue.Items.Clear();
        }
        #endregion

        private void btnGene_Click(object sender, EventArgs e)
        {
            int head = 0;
            int tail = 0;
            int num = 0;
            if (!(int.TryParse(txtBoxHead.Text, out head) && int.TryParse(txtBoxTail.Text, out tail) && int.TryParse(txtBoxNum.Text, out num)))
            {
                MessageBox.Show("ConvertError");
                return;
            }
            if (head <= 0 || tail <= 0 || num <= 0 || tail < head + 1)
            {
                MessageBox.Show("ValueError");
                return;
            }
            listBoxGene.Items.Clear();
            char[] OperatorAndLetter = new char[listBoxOperator.Items.Count + listBoxLetter.Items.Count];
            char[] value = new char[listBoxValue.Items.Count];
            for (int i = 0; i < listBoxOperator.Items.Count; i++)
            {
                OperatorAndLetter[i] = Convert.ToChar(listBoxOperator.Items[i]);
            }
            for (int i = listBoxOperator.Items.Count; i < OperatorAndLetter.Length; i++)
            {
                OperatorAndLetter[i] = Convert.ToChar(listBoxLetter.Items[i - listBoxOperator.Items.Count].ToString());
            }

            int k = 0;
            Random random = new Random();

            int count = 0;
            StringBuilder sb = new StringBuilder();
            while (count++ < num)
            {
                sb.Clear();
                k = 0;
                for (; k < head; k++)
                {
                    sb.Append(OperatorAndLetter[random.Next(OperatorAndLetter.Length)]);
                }
                for (; k < head + tail; k++)
                {
                    sb.Append(OperatorAndLetter[random.Next(listBoxOperator.Items.Count, OperatorAndLetter.Length)]);
                }
                listBoxGene.Items.Add(sb.ToString());
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (listBoxValue.Items.Count < listBoxLetter.Items.Count)
            {
                MessageBox.Show("Please fill the Value");
                return ;
            }
            for (int i = 0; i < listBoxGene.Items.Count; i++)
            {
                string tmp = listBoxGene.Items[i].ToString();
                Dictionary<int, string> dic = new Dictionary<int, string>();
                dic.Add(1,LetterToValue(tmp[0]));
                for (int j = 1; j < tmp.Length; j++)
                {
                    #region 遍历dic 
                    foreach (var dicKV in dic)
                    {
                        char ch;
                        if(char.TryParse(dicKV.Value,out ch)&&!char.IsDigit(ch))
                        {
                            if (!char.IsLower(ch))
                            {
                                if (char.IsLetter(ch))
                                {
                                    if (!dic.ContainsKey(2 * dicKV.Key))
                                    {
                                        dic.Add(2 * dicKV.Key, LetterToValue(tmp[j]));
                                        break;
                                    }
                                }
                                else
                                {
                                    if (!dic.ContainsKey(2 * dicKV.Key))
                                    {
                                        dic.Add(2 * dicKV.Key, LetterToValue(tmp[j]));
                                        break;
                                    }
                                    else if (!dic.ContainsKey(2 * dicKV.Key + 1))
                                    {
                                        dic.Add(2 * dicKV.Key + 1, LetterToValue(tmp[j]));
                                        break;
                                    }
                                }
                            }
                        }
                    } 
                    #endregion
                }
                while (dic.Count > 1)
                {
                    if (dic.Last().Key % 2 == 1)
                    { //双目运算符处理
                        dic[dic.Last().Key / 2] = SimplyCal(Convert.ToDouble(dic[dic.Last().Key - 1]),
                                                                            dic[dic.Last().Key / 2],
                                                                            Convert.ToDouble(dic[dic.Last().Key])
                                                                            ).ToString();
                        dic.Remove(dic.Last().Key);
                        dic.Remove(dic.Last().Key);
                    }
                    else
                    {//单目运算符处理
                        dic[dic.Last().Key / 2] = SimplyCal(Convert.ToDouble(dic[dic.Last().Key]),
                                                                            dic[dic.Last().Key / 2]
                                                                            ).ToString();
                        dic.Remove(dic.Last().Key);
                    }
                }
                listBoxResult.Items.Add(listBoxGene.Items[i]+" : "+dic[1]);                   
            }
        }

        private double SimplyCal(double a, string ch, double b = 0)
        {
            switch (ch)
            {
                case "+": return a + b;
                case "-": return a - b;
                case "*": return a * b;
                case "/": return a / b;
                case "%": return a % b;
                case "^": return Math.Pow(a, b);
                case "S": return Math.Pow(a, 2);
                case "Q": return Math.Sqrt(a);
                default:
                    return 0;
            }
        }
        private string LetterToValue(char ch)
        {
            if (listBoxLetter.Items.Contains(ch.ToString()))
            {
                return listBoxValue.Items[listBoxLetter.Items.IndexOf(ch.ToString())].ToString();
            }
            else
            {
                return ch.ToString();
            }
        }
    }
}
