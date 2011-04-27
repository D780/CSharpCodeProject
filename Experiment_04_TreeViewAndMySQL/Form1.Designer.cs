namespace Experiment_04_TreeViewAndMySQL
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
            this.components = new System.ComponentModel.Container();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.cMStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TNodeAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TNodeEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.TNodeDel = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox.SuspendLayout();
            this.cMStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.treeView);
            this.groupBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox.Location = new System.Drawing.Point(5, 13);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox.Size = new System.Drawing.Size(763, 476);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "学校层级关系列表";
            // 
            // treeView
            // 
            this.treeView.ContextMenuStrip = this.cMStrip;
            this.treeView.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView.Location = new System.Drawing.Point(9, 29);
            this.treeView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(742, 439);
            this.treeView.TabIndex = 0;
            this.treeView.DoubleClick += new System.EventHandler(this.treeView_DoubleClick);
            this.treeView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseClick);
            // 
            // cMStrip
            // 
            this.cMStrip.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.cMStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TNodeAdd,
            this.toolStripSeparator1,
            this.TNodeEdit,
            this.TNodeDel});
            this.cMStrip.Name = "cMStrip";
            this.cMStrip.Size = new System.Drawing.Size(163, 82);
            // 
            // TNodeAdd
            // 
            this.TNodeAdd.Name = "TNodeAdd";
            this.TNodeAdd.Size = new System.Drawing.Size(162, 24);
            this.TNodeAdd.Text = "增加子节点";
            this.TNodeAdd.Click += new System.EventHandler(this.TNodeAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // TNodeEdit
            // 
            this.TNodeEdit.Name = "TNodeEdit";
            this.TNodeEdit.Size = new System.Drawing.Size(162, 24);
            this.TNodeEdit.Text = "修改节点内容";
            this.TNodeEdit.Click += new System.EventHandler(this.TNodeEdit_Click);
            // 
            // TNodeDel
            // 
            this.TNodeDel.Name = "TNodeDel";
            this.TNodeDel.Size = new System.Drawing.Size(162, 24);
            this.TNodeDel.Text = "删除节点";
            this.TNodeDel.Click += new System.EventHandler(this.TNodeDel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 491);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(785, 530);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(785, 530);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.cMStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ContextMenuStrip cMStrip;
        private System.Windows.Forms.ToolStripMenuItem TNodeAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TNodeEdit;
        private System.Windows.Forms.ToolStripMenuItem TNodeDel;
    }
}

