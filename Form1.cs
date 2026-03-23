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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void checkShowHideOrPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowHideOrPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                checkShowHideOrPassword.Text = "Hide";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                checkShowHideOrPassword.Text = "Show";

            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUserName.Text == "ahmed" && txtPassword.Text == "1234")
            {
                MessageBox.Show("Login Successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form frmMain = new frmMainScreen();
                this.Hide();
                frmMain.ShowDialog();
                this.Show();
            }
            else
            {

                MessageBox.Show("Login Faild", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtUserName.Text = null;
            txtPassword.Text = null;
            checkShowHideOrPassword.Checked = false;

        }

        private void linkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frmCreateAccount = new frmCreateAccountScreen();
            this.Hide();
            frmCreateAccount.ShowDialog();
            this.Show();
            
        }
    }
}
