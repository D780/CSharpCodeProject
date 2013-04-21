namespace WindowsFormsApplication1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxTail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxHead = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxValue = new System.Windows.Forms.ListBox();
            this.listBoxLetter = new System.Windows.Forms.ListBox();
            this.listBoxOperator = new System.Windows.Forms.ListBox();
            this.btnValueDelAll = new System.Windows.Forms.Button();
            this.btnLetterDelAll = new System.Windows.Forms.Button();
            this.btnOperatorDelAll = new System.Windows.Forms.Button();
            this.btnValueDel = new System.Windows.Forms.Button();
            this.btnLetterDel = new System.Windows.Forms.Button();
            this.btnOperatorDel = new System.Windows.Forms.Button();
            this.btnValueAdd = new System.Windows.Forms.Button();
            this.btnLetterAdd = new System.Windows.Forms.Button();
            this.btnOperatorAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxValue = new System.Windows.Forms.TextBox();
            this.txtBoxLetter = new System.Windows.Forms.TextBox();
            this.txtBoxOperator = new System.Windows.Forms.TextBox();
            this.btnGene = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxGene = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxNum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxTail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxHead);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "算法相关参数设置";
            // 
            // txtBoxNum
            // 
            this.txtBoxNum.Location = new System.Drawing.Point(403, 18);
            this.txtBoxNum.Name = "txtBoxNum";
            this.txtBoxNum.Size = new System.Drawing.Size(45, 21);
            this.txtBoxNum.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "字串数量";
            // 
            // txtBoxTail
            // 
            this.txtBoxTail.Location = new System.Drawing.Point(257, 18);
            this.txtBoxTail.Name = "txtBoxTail";
            this.txtBoxTail.Size = new System.Drawing.Size(45, 21);
            this.txtBoxTail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "字串尾部长度";
            // 
            // txtBoxHead
            // 
            this.txtBoxHead.Location = new System.Drawing.Point(90, 18);
            this.txtBoxHead.Name = "txtBoxHead";
            this.txtBoxHead.Size = new System.Drawing.Size(45, 21);
            this.txtBoxHead.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "字串头部长度";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxValue);
            this.groupBox2.Controls.Add(this.listBoxLetter);
            this.groupBox2.Controls.Add(this.listBoxOperator);
            this.groupBox2.Controls.Add(this.btnValueDelAll);
            this.groupBox2.Controls.Add(this.btnLetterDelAll);
            this.groupBox2.Controls.Add(this.btnOperatorDelAll);
            this.groupBox2.Controls.Add(this.btnValueDel);
            this.groupBox2.Controls.Add(this.btnLetterDel);
            this.groupBox2.Controls.Add(this.btnOperatorDel);
            this.groupBox2.Controls.Add(this.btnValueAdd);
            this.groupBox2.Controls.Add(this.btnLetterAdd);
            this.groupBox2.Controls.Add(this.btnOperatorAdd);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBoxValue);
            this.groupBox2.Controls.Add(this.txtBoxLetter);
            this.groupBox2.Controls.Add(this.txtBoxOperator);
            this.groupBox2.Location = new System.Drawing.Point(13, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "表达式参数设置";
            // 
            // listBoxValue
            // 
            this.listBoxValue.FormattingEnabled = true;
            this.listBoxValue.ItemHeight = 12;
            this.listBoxValue.Location = new System.Drawing.Point(445, 20);
            this.listBoxValue.Name = "listBoxValue";
            this.listBoxValue.Size = new System.Drawing.Size(54, 64);
            this.listBoxValue.TabIndex = 2;
            // 
            // listBoxLetter
            // 
            this.listBoxLetter.FormattingEnabled = true;
            this.listBoxLetter.ItemHeight = 12;
            this.listBoxLetter.Location = new System.Drawing.Point(272, 20);
            this.listBoxLetter.Name = "listBoxLetter";
            this.listBoxLetter.Size = new System.Drawing.Size(52, 64);
            this.listBoxLetter.TabIndex = 2;
            // 
            // listBoxOperator
            // 
            this.listBoxOperator.FormattingEnabled = true;
            this.listBoxOperator.ItemHeight = 12;
            this.listBoxOperator.Location = new System.Drawing.Point(94, 21);
            this.listBoxOperator.Name = "listBoxOperator";
            this.listBoxOperator.Size = new System.Drawing.Size(52, 64);
            this.listBoxOperator.TabIndex = 2;
            // 
            // btnValueDelAll
            // 
            this.btnValueDelAll.Location = new System.Drawing.Point(402, 66);
            this.btnValueDelAll.Name = "btnValueDelAll";
            this.btnValueDelAll.Size = new System.Drawing.Size(37, 23);
            this.btnValueDelAll.TabIndex = 1;
            this.btnValueDelAll.Text = "全删";
            this.btnValueDelAll.UseVisualStyleBackColor = true;
            this.btnValueDelAll.Click += new System.EventHandler(this.btnValueDelAll_Click);
            // 
            // btnLetterDelAll
            // 
            this.btnLetterDelAll.Location = new System.Drawing.Point(229, 66);
            this.btnLetterDelAll.Name = "btnLetterDelAll";
            this.btnLetterDelAll.Size = new System.Drawing.Size(37, 23);
            this.btnLetterDelAll.TabIndex = 1;
            this.btnLetterDelAll.Text = "全删";
            this.btnLetterDelAll.UseVisualStyleBackColor = true;
            this.btnLetterDelAll.Click += new System.EventHandler(this.btnLetterDelAll_Click);
            // 
            // btnOperatorDelAll
            // 
            this.btnOperatorDelAll.Location = new System.Drawing.Point(51, 66);
            this.btnOperatorDelAll.Name = "btnOperatorDelAll";
            this.btnOperatorDelAll.Size = new System.Drawing.Size(37, 23);
            this.btnOperatorDelAll.TabIndex = 1;
            this.btnOperatorDelAll.Text = "全删";
            this.btnOperatorDelAll.UseVisualStyleBackColor = true;
            this.btnOperatorDelAll.Click += new System.EventHandler(this.btnOperatorDelAll_Click);
            // 
            // btnValueDel
            // 
            this.btnValueDel.Location = new System.Drawing.Point(362, 66);
            this.btnValueDel.Name = "btnValueDel";
            this.btnValueDel.Size = new System.Drawing.Size(37, 23);
            this.btnValueDel.TabIndex = 1;
            this.btnValueDel.Text = "清除";
            this.btnValueDel.UseVisualStyleBackColor = true;
            this.btnValueDel.Click += new System.EventHandler(this.btnValueDel_Click);
            // 
            // btnLetterDel
            // 
            this.btnLetterDel.Location = new System.Drawing.Point(189, 66);
            this.btnLetterDel.Name = "btnLetterDel";
            this.btnLetterDel.Size = new System.Drawing.Size(37, 23);
            this.btnLetterDel.TabIndex = 1;
            this.btnLetterDel.Text = "清除";
            this.btnLetterDel.UseVisualStyleBackColor = true;
            this.btnLetterDel.Click += new System.EventHandler(this.btnLetterDel_Click);
            // 
            // btnOperatorDel
            // 
            this.btnOperatorDel.Location = new System.Drawing.Point(11, 66);
            this.btnOperatorDel.Name = "btnOperatorDel";
            this.btnOperatorDel.Size = new System.Drawing.Size(37, 23);
            this.btnOperatorDel.TabIndex = 1;
            this.btnOperatorDel.Text = "清除";
            this.btnOperatorDel.UseVisualStyleBackColor = true;
            this.btnOperatorDel.Click += new System.EventHandler(this.btnOperatorDel_Click);
            // 
            // btnValueAdd
            // 
            this.btnValueAdd.Location = new System.Drawing.Point(362, 37);
            this.btnValueAdd.Name = "btnValueAdd";
            this.btnValueAdd.Size = new System.Drawing.Size(37, 23);
            this.btnValueAdd.TabIndex = 1;
            this.btnValueAdd.Text = "添加";
            this.btnValueAdd.UseVisualStyleBackColor = true;
            this.btnValueAdd.Click += new System.EventHandler(this.btnValueAdd_Click);
            // 
            // btnLetterAdd
            // 
            this.btnLetterAdd.Location = new System.Drawing.Point(189, 37);
            this.btnLetterAdd.Name = "btnLetterAdd";
            this.btnLetterAdd.Size = new System.Drawing.Size(37, 23);
            this.btnLetterAdd.TabIndex = 1;
            this.btnLetterAdd.Text = "添加";
            this.btnLetterAdd.UseVisualStyleBackColor = true;
            this.btnLetterAdd.Click += new System.EventHandler(this.btnLetterAdd_Click);
            // 
            // btnOperatorAdd
            // 
            this.btnOperatorAdd.Location = new System.Drawing.Point(11, 37);
            this.btnOperatorAdd.Name = "btnOperatorAdd";
            this.btnOperatorAdd.Size = new System.Drawing.Size(37, 23);
            this.btnOperatorAdd.TabIndex = 1;
            this.btnOperatorAdd.Text = "添加";
            this.btnOperatorAdd.UseVisualStyleBackColor = true;
            this.btnOperatorAdd.Click += new System.EventHandler(this.btnOperatorAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "变量数值";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "变量字母表";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "运算符字母表";
            // 
            // txtBoxValue
            // 
            this.txtBoxValue.Location = new System.Drawing.Point(405, 36);
            this.txtBoxValue.Name = "txtBoxValue";
            this.txtBoxValue.Size = new System.Drawing.Size(34, 21);
            this.txtBoxValue.TabIndex = 1;
            // 
            // txtBoxLetter
            // 
            this.txtBoxLetter.Location = new System.Drawing.Point(232, 36);
            this.txtBoxLetter.Name = "txtBoxLetter";
            this.txtBoxLetter.Size = new System.Drawing.Size(34, 21);
            this.txtBoxLetter.TabIndex = 1;
            // 
            // txtBoxOperator
            // 
            this.txtBoxOperator.Location = new System.Drawing.Point(54, 36);
            this.txtBoxOperator.Name = "txtBoxOperator";
            this.txtBoxOperator.Size = new System.Drawing.Size(34, 21);
            this.txtBoxOperator.TabIndex = 1;
            // 
            // btnGene
            // 
            this.btnGene.Location = new System.Drawing.Point(13, 173);
            this.btnGene.Name = "btnGene";
            this.btnGene.Size = new System.Drawing.Size(251, 23);
            this.btnGene.TabIndex = 1;
            this.btnGene.Text = "1、生成基因群（即堂作业）";
            this.btnGene.UseVisualStyleBackColor = true;
            this.btnGene.Click += new System.EventHandler(this.btnGene_Click);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(291, 173);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(251, 23);
            this.btnResult.TabIndex = 1;
            this.btnResult.Text = "2、计算结果（课后练习）";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxGene);
            this.groupBox3.Location = new System.Drawing.Point(13, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 274);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "生成基因";
            // 
            // listBoxGene
            // 
            this.listBoxGene.FormattingEnabled = true;
            this.listBoxGene.ItemHeight = 12;
            this.listBoxGene.Location = new System.Drawing.Point(9, 21);
            this.listBoxGene.Name = "listBoxGene";
            this.listBoxGene.Size = new System.Drawing.Size(236, 244);
            this.listBoxGene.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBoxResult);
            this.groupBox4.Location = new System.Drawing.Point(291, 203);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(251, 274);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "计算结果";
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 12;
            this.listBoxResult.Location = new System.Drawing.Point(9, 21);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(236, 244);
            this.listBoxResult.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 489);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnGene);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxTail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxHead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxValue;
        private System.Windows.Forms.ListBox listBoxLetter;
        private System.Windows.Forms.ListBox listBoxOperator;
        private System.Windows.Forms.Button btnValueDelAll;
        private System.Windows.Forms.Button btnLetterDelAll;
        private System.Windows.Forms.Button btnOperatorDelAll;
        private System.Windows.Forms.Button btnValueDel;
        private System.Windows.Forms.Button btnLetterDel;
        private System.Windows.Forms.Button btnOperatorDel;
        private System.Windows.Forms.Button btnValueAdd;
        private System.Windows.Forms.Button btnLetterAdd;
        private System.Windows.Forms.Button btnOperatorAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxValue;
        private System.Windows.Forms.TextBox txtBoxLetter;
        private System.Windows.Forms.TextBox txtBoxOperator;
        private System.Windows.Forms.Button btnGene;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxGene;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBoxResult;
    }
}

