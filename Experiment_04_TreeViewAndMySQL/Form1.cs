using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Experiment_04_TreeViewAndMySQL
{
    public partial class Form1 : Form
    {
        List<TreeNode> listNode = new List<TreeNode>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            update();
        }

        private void treeView_MouseClick(object sender, MouseEventArgs e)
        {
            treeView.SelectedNode = treeView.GetNodeAt(e.X, e.Y);
            treeView.ExpandAll();
        }

        private void TNodeDel_Click(object sender, EventArgs e)
        {
            TreeNode tn = treeView.SelectedNode;
            if (tn.Tag.ToString().Length / 2 == 1)
            {
                MessageBox.Show("不能删除根节点");
                return;
            }
            else
            {
                if (MessageBox.Show("是否要删除该节点?", "确定", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    tTableDiffcult db = new tTableDiffcult();
                    if (db.Delete(Convert.ToInt32(tn.Tag)))
                    {
                        MessageBox.Show("删除节点成功");
                    }
                    else
                    {
                        MessageBox.Show("删除节点失败");
                    }
                }
                update();
            }
        }

        private void TNodeAdd_Click(object sender, EventArgs e)
        {
            FormDetail fd = new FormDetail(treeView.SelectedNode, "Add");
            fd.ShowDialog(this);
            update();
        }

        private void TNodeEdit_Click(object sender, EventArgs e)
        {
            FormDetail fd = new FormDetail(treeView.SelectedNode, "Edit");
            fd.ShowDialog(this);
            update();
        }

        private void update()
        {
            listNode.Clear();
            treeView.Nodes.Clear();

            tTableDiffcult db = new tTableDiffcult();
            DataTable dt = db.SelectAll();

            foreach (DataRow row in dt.Rows)
            {
                TreeNode tn = new TreeNode(row["fName"].ToString());
                tn.Tag = row["fid"].ToString();
                listNode.Add(tn);
                if (tn.Tag.ToString().Length / 2 == 1)
                {
                    treeView.Nodes.Add(tn);
                }
                else
                {
                    foreach (TreeNode tmpTn in listNode)
                    {
                        if (tmpTn.Tag.ToString().Equals(tn.Tag.ToString().Substring(0, tn.Tag.ToString().Length - 2)))
                        {
                            tmpTn.Nodes.Add(tn);
                            break;
                        }
                    }
                }
            }
            treeView.ExpandAll();
        }

        private void treeView_DoubleClick(object sender, EventArgs e)
        {
            TreeNode tn = treeView.SelectedNode;
            tTableDiffcult db = new tTableDiffcult();
            DataTable dt = db.Select(Convert.ToInt32(tn.Tag));
            MessageBox.Show(string.Format("节点名称:{0}\r\n节点层级:{1}\r\n节点备注:{2}\r\n",
                dt.Rows[0]["fName"], dt.Rows[0]["fid"].ToString().Length / 2 - 1, dt.Rows[0]["fRemark"]));
            treeView.ExpandAll();
        }
    }
}
