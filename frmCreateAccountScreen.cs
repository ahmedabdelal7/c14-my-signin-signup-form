using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class frmCreateAccountScreen : Form
    {
        public frmCreateAccountScreen()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Account Created Successfully","Done",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkAgree_CheckedChanged(object sender, EventArgs e)
        {
            btnCreateAccount.Enabled = chkAgree.Checked;
        }
    }
}
