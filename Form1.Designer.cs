namespace LoginForm
{
    partial class Form1
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
            this.labLoginScreen = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.labUserName = new System.Windows.Forms.Label();
            this.labPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.checkShowHideOrPassword = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.linkCreateAccount = new System.Windows.Forms.LinkLabel();
            this.labCreateAccount = new System.Windows.Forms.Label();
            this.chkRememberMe = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labLoginScreen
            // 
            this.labLoginScreen.AutoSize = true;
            this.labLoginScreen.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLoginScreen.Location = new System.Drawing.Point(282, 60);
            this.labLoginScreen.Name = "labLoginScreen";
            this.labLoginScreen.Size = new System.Drawing.Size(231, 34);
            this.labLoginScreen.TabIndex = 0;
            this.labLoginScreen.Text = "Login Screen";
            // 
            // txtUserName
            // 
            this.txtUserName.AccessibleDescription = "";
            this.txtUserName.AccessibleName = "";
            this.txtUserName.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(279, 158);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(250, 29);
            this.txtUserName.TabIndex = 0;
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUserName.Location = new System.Drawing.Point(135, 158);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(147, 29);
            this.labUserName.TabIndex = 2;
            this.labUserName.Text = "User Name: ";
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPassword.Location = new System.Drawing.Point(135, 222);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(126, 29);
            this.labPassword.TabIndex = 4;
            this.labPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.AccessibleDescription = "";
            this.txtPassword.AccessibleName = "";
            this.txtPassword.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(279, 224);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(250, 29);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // checkShowHideOrPassword
            // 
            this.checkShowHideOrPassword.AutoSize = true;
            this.checkShowHideOrPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkShowHideOrPassword.Location = new System.Drawing.Point(544, 228);
            this.checkShowHideOrPassword.Name = "checkShowHideOrPassword";
            this.checkShowHideOrPassword.Size = new System.Drawing.Size(73, 26);
            this.checkShowHideOrPassword.TabIndex = 2;
            this.checkShowHideOrPassword.TabStop = false;
            this.checkShowHideOrPassword.Text = "Show";
            this.checkShowHideOrPassword.UseVisualStyleBackColor = true;
            this.checkShowHideOrPassword.CheckedChanged += new System.EventHandler(this.checkShowHideOrPassword_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.AutoEllipsis = true;
            this.btnLogin.BackColor = System.Drawing.Color.LawnGreen;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnLogin.FlatAppearance.BorderSize = 2;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(339, 325);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(116, 51);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linkCreateAccount
            // 
            this.linkCreateAccount.AutoSize = true;
            this.linkCreateAccount.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCreateAccount.Location = new System.Drawing.Point(420, 412);
            this.linkCreateAccount.Name = "linkCreateAccount";
            this.linkCreateAccount.Size = new System.Drawing.Size(134, 23);
            this.linkCreateAccount.TabIndex = 4;
            this.linkCreateAccount.TabStop = true;
            this.linkCreateAccount.Text = "Create Account";
            this.linkCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCreateAccount_LinkClicked);
            // 
            // labCreateAccount
            // 
            this.labCreateAccount.AutoSize = true;
            this.labCreateAccount.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCreateAccount.Location = new System.Drawing.Point(232, 412);
            this.labCreateAccount.Name = "labCreateAccount";
            this.labCreateAccount.Size = new System.Drawing.Size(175, 23);
            this.labCreateAccount.TabIndex = 6;
            this.labCreateAccount.Text = "Dont have account? ";
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRememberMe.Location = new System.Drawing.Point(279, 269);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(154, 27);
            this.chkRememberMe.TabIndex = 2;
            this.chkRememberMe.Text = "Remember Me";
            this.chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(752, 494);
            this.Controls.Add(this.chkRememberMe);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.linkCreateAccount);
            this.Controls.Add(this.labCreateAccount);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.checkShowHideOrPassword);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labUserName);
            this.Controls.Add(this.labLoginScreen);
            this.Name = "Form1";
            this.Text = "Login Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labLoginScreen;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label labUserName;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox checkShowHideOrPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel linkCreateAccount;
        private System.Windows.Forms.Label labCreateAccount;
        private System.Windows.Forms.CheckBox chkRememberMe;
    }
}

