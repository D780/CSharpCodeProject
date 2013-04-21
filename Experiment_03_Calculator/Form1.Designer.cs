namespace Experiment_03_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.txtBoxResult = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnGroupBox = new System.Windows.Forms.GroupBox();
            this.btnLn = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnTg = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnRightBracket = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnLeftBracket = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnSpace = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "公式输入";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "运算结果";
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Location = new System.Drawing.Point(78, 9);
            this.txtBoxInput.Multiline = true;
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(312, 58);
            this.txtBoxInput.TabIndex = 2;
            // 
            // txtBoxResult
            // 
            this.txtBoxResult.Location = new System.Drawing.Point(78, 75);
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.ReadOnly = true;
            this.txtBoxResult.Size = new System.Drawing.Size(312, 21);
            this.txtBoxResult.TabIndex = 3;
            this.txtBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(399, 6);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(69, 90);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "计算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            this.btnCalculate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnCalculate_KeyPress);
            // 
            // btnGroupBox
            // 
            this.btnGroupBox.Controls.Add(this.btnLn);
            this.btnGroupBox.Controls.Add(this.btnPow);
            this.btnGroupBox.Controls.Add(this.btnAdd);
            this.btnGroupBox.Controls.Add(this.btnDot);
            this.btnGroupBox.Controls.Add(this.btn0);
            this.btnGroupBox.Controls.Add(this.btnTg);
            this.btnGroupBox.Controls.Add(this.btnSqrt);
            this.btnGroupBox.Controls.Add(this.btnSub);
            this.btnGroupBox.Controls.Add(this.btn3);
            this.btnGroupBox.Controls.Add(this.btn2);
            this.btnGroupBox.Controls.Add(this.btn1);
            this.btnGroupBox.Controls.Add(this.btnCos);
            this.btnGroupBox.Controls.Add(this.btnRightBracket);
            this.btnGroupBox.Controls.Add(this.btnMul);
            this.btnGroupBox.Controls.Add(this.btn4);
            this.btnGroupBox.Controls.Add(this.btn5);
            this.btnGroupBox.Controls.Add(this.btn6);
            this.btnGroupBox.Controls.Add(this.btnSin);
            this.btnGroupBox.Controls.Add(this.btnLeftBracket);
            this.btnGroupBox.Controls.Add(this.btnMod);
            this.btnGroupBox.Controls.Add(this.btnDiv);
            this.btnGroupBox.Controls.Add(this.btnSpace);
            this.btnGroupBox.Controls.Add(this.btnBack);
            this.btnGroupBox.Controls.Add(this.btn9);
            this.btnGroupBox.Controls.Add(this.btnClear);
            this.btnGroupBox.Controls.Add(this.btn8);
            this.btnGroupBox.Controls.Add(this.btn7);
            this.btnGroupBox.Location = new System.Drawing.Point(14, 102);
            this.btnGroupBox.Name = "btnGroupBox";
            this.btnGroupBox.Size = new System.Drawing.Size(466, 261);
            this.btnGroupBox.TabIndex = 5;
            this.btnGroupBox.TabStop = false;
            // 
            // btnLn
            // 
            this.btnLn.Location = new System.Drawing.Point(385, 210);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(69, 43);
            this.btnLn.TabIndex = 0;
            this.btnLn.Text = " ln ";
            this.btnLn.UseVisualStyleBackColor = true;
            this.btnLn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            // 
            // btnPow
            // 
            this.btnPow.Location = new System.Drawing.Point(385, 112);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(69, 43);
            this.btnPow.TabIndex = 0;
            this.btnPow.Text = "x^y";
            this.btnPow.UseVisualStyleBackColor = true;
            this.btnPow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(235, 161);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 43);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(85, 212);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(69, 43);
            this.btnDot.TabIndex = 0;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(10, 210);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(69, 43);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            // 
            // btnTg
            // 
            this.btnTg.Location = new System.Drawing.Point(310, 210);
            this.btnTg.Name = "btnTg";
            this.btnTg.Size = new System.Drawing.Size(69, 43);
            this.btnTg.TabIndex = 0;
            this.btnTg.Text = " tg ";
            this.btnTg.UseVisualStyleBackColor = true;
            this.btnTg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Location = new System.Drawing.Point(310, 112);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(69, 43);
            this.btnSqrt.TabIndex = 0;
            this.btnSqrt.Text = " sqrt ";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(235, 112);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(69, 43);
            this.btnSub.TabIndex = 0;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(160, 161);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(69, 43);
            this.btn3.TabIndex = 0;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(85, 161);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(69, 43);
            this.btn2.TabIndex = 0;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(10, 161);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(69, 43);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            // 
            // btnCos
            // 
            this.btnCos.Location = new System.Drawing.Point(385, 161);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(69, 43);
            this.btnCos.TabIndex = 0;
            this.btnCos.Text = " cos ";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            // 
            // btnRightBracket
            // 
            this.btnRightBracket.Location = new System.Drawing.Point(385, 14);
            this.btnRightBracket.Name = "btnRightBracket";
            this.btnRightBracket.Size = new System.Drawing.Size(69, 43);
            this.btnRightBracket.TabIndex = 0;
            this.btnRightBracket.Text = ")";
            this.btnRightBracket.UseVisualStyleBackColor = true;
            this.btnRightBracket.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(235, 63);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(69, 43);
            this.btnMul.TabIndex = 0;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(10, 112);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(69, 43);
            this.btn4.TabIndex = 0;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(85, 112);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(69, 43);
            this.btn5.TabIndex = 0;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(160, 112);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(69, 43);
            this.btn6.TabIndex = 0;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            // 
            // btnSin
            // 
            this.btnSin.Location = new System.Drawing.Point(310, 161);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(69, 43);
            this.btnSin.TabIndex = 0;
            this.btnSin.Text = " sin ";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            // 
            // btnLeftBracket
            // 
            this.btnLeftBracket.Location = new System.Drawing.Point(310, 14);
            this.btnLeftBracket.Name = "btnLeftBracket";
            this.btnLeftBracket.Size = new System.Drawing.Size(69, 43);
            this.btnLeftBracket.TabIndex = 0;
            this.btnLeftBracket.Text = "(";
            this.btnLeftBracket.UseVisualStyleBackColor = true;
            this.btnLeftBracket.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(385, 63);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(69, 43);
            this.btnMod.TabIndex = 0;
            this.btnMod.Text = "%";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(310, 63);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(69, 43);
            this.btnDiv.TabIndex = 0;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            // 
            // btnSpace
            // 
            this.btnSpace.Location = new System.Drawing.Point(160, 212);
            this.btnSpace.Name = "btnSpace";
            this.btnSpace.Size = new System.Drawing.Size(144, 43);
            this.btnSpace.TabIndex = 0;
            this.btnSpace.UseVisualStyleBackColor = true;
            this.btnSpace.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(85, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(69, 43);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(160, 63);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(69, 43);
            this.btn9.TabIndex = 0;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(10, 14);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(69, 43);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(85, 63);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(69, 43);
            this.btn8.TabIndex = 0;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(10, 63);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(69, 43);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 368);
            this.Controls.Add(this.btnGroupBox);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtBoxResult);
            this.Controls.Add(this.txtBoxInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(503, 407);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(503, 407);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "演算器";
            this.btnGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.TextBox txtBoxResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox btnGroupBox;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnTg;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnRightBracket;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnLeftBracket;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSpace;
    }
}

