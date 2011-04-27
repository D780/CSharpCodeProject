namespace Experiment_04_TreeViewAndMySQL
{
    partial class FormDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtBox_fName = new System.Windows.Forms.TextBox();
            this.txtBox_fRemark = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "节点名称:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "节点备注:";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.btnOK.Location = new System.Drawing.Point(93, 314);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 38);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "增加";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.btnCancel.Location = new System.Drawing.Point(253, 314);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 38);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtBox_fName
            // 
            this.txtBox_fName.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.txtBox_fName.Location = new System.Drawing.Point(93, 17);
            this.txtBox_fName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBox_fName.Name = "txtBox_fName";
            this.txtBox_fName.Size = new System.Drawing.Size(260, 26);
            this.txtBox_fName.TabIndex = 2;
            // 
            // txtBox_fRemark
            // 
            this.txtBox_fRemark.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.txtBox_fRemark.Location = new System.Drawing.Point(93, 53);
            this.txtBox_fRemark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBox_fRemark.Multiline = true;
            this.txtBox_fRemark.Name = "txtBox_fRemark";
            this.txtBox_fRemark.Size = new System.Drawing.Size(260, 251);
            this.txtBox_fRemark.TabIndex = 2;
            // 
            // FormDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 367);
            this.Controls.Add(this.txtBox_fRemark);
            this.Controls.Add(this.txtBox_fName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(459, 406);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(459, 406);
            this.Name = "FormDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtBox_fName;
        private System.Windows.Forms.TextBox txtBox_fRemark;
    }
}