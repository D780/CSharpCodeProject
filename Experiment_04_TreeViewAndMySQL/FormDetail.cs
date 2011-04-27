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
    public partial class FormDetail : Form
    {
        TreeNode tn; string op;
        public FormDetail(TreeNode tn, string op)
        {
            InitializeComponent();

            this.tn = tn;
            this.op = op;
            if (op.Equals("Add"))
            {
            }
            else if (op.Equals("Edit"))
            {
                tTableDiffcult db = new tTableDiffcult();
                DataTable dt = db.Select(Convert.ToInt32(tn.Tag));
                btnOK.Text = "修改";
                txtBox_fName.Text = dt.Rows[0]["fName"].ToString();
                txtBox_fRemark.Text = dt.Rows[0]["fRemark"].ToString();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            tTableDiffcult db = new tTableDiffcult();
            if (op.Equals("Add"))
            {
                int fid = Convert.ToInt32(tn.Tag) * 100 + tn.Nodes.Count;
                db.Insert(fid, txtBox_fName.Text, txtBox_fRemark.Text);
            }
            else if (op.Equals("Edit"))
            {
                db.updateByID(Convert.ToInt32(tn.Tag), txtBox_fName.Text, txtBox_fRemark.Text);
            }
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
