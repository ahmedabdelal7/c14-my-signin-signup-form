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
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
            DateTime dt = DateTime.Now;
            labLoginDate.Text = "Login Date/Time: "+dt.ToString();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To Sign Out?", "Sign Out", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK) {
                this.Close();
            }

        }

        private void labLoginDate_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labLoginDate.Text = dt.ToString();
        }
    }
}
