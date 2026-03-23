namespace LoginForm
{
    partial class frmMainScreen
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
            this.labFirstName = new System.Windows.Forms.Label();
            this.labLastName = new System.Windows.Forms.Label();
            this.labUserName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labPassword = new System.Windows.Forms.Label();
            this.labGender = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.labLoginDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labFirstName
            // 
            this.labFirstName.AutoSize = true;
            this.labFirstName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFirstName.Location = new System.Drawing.Point(66, 168);
            this.labFirstName.Name = "labFirstName";
            this.labFirstName.Size = new System.Drawing.Size(207, 27);
            this.labFirstName.TabIndex = 0;
            this.labFirstName.Text = "First Name : Ahmed ";
            // 
            // labLastName
            // 
            this.labLastName.AutoSize = true;
            this.labLastName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLastName.Location = new System.Drawing.Point(295, 168);
            this.labLastName.Name = "labLastName";
            this.labLastName.Size = new System.Drawing.Size(247, 27);
            this.labLastName.TabIndex = 1;
            this.labLastName.Text = "Last Name : Mohammed";
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUserName.Location = new System.Drawing.Point(66, 229);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(201, 27);
            this.labUserName.TabIndex = 2;
            this.labUserName.Text = "User Name: ahmed ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(188, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Your Information";
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPassword.Location = new System.Drawing.Point(295, 229);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(168, 27);
            this.labPassword.TabIndex = 4;
            this.labPassword.Text = "Password : 1234";
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGender.Location = new System.Drawing.Point(66, 284);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(140, 27);
            this.labGender.TabIndex = 5;
            this.labGender.Text = "Gender: Male";
            // 
            // btnSignOut
            // 
            this.btnSignOut.AutoEllipsis = true;
            this.btnSignOut.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignOut.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnSignOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnSignOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Location = new System.Drawing.Point(423, 349);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(132, 56);
            this.btnSignOut.TabIndex = 0;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // labLoginDate
            // 
            this.labLoginDate.AutoSize = true;
            this.labLoginDate.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLoginDate.Location = new System.Drawing.Point(111, 106);
            this.labLoginDate.Name = "labLoginDate";
            this.labLoginDate.Size = new System.Drawing.Size(54, 21);
            this.labLoginDate.TabIndex = 6;
            this.labLoginDate.Text = "Date:";
            this.labLoginDate.Click += new System.EventHandler(this.labLoginDate_Click);
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(620, 447);
            this.Controls.Add(this.labLoginDate);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.labGender);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labUserName);
            this.Controls.Add(this.labLastName);
            this.Controls.Add(this.labFirstName);
            this.Name = "frmMainScreen";
            this.Text = "Main Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labFirstName;
        private System.Windows.Forms.Label labLastName;
        private System.Windows.Forms.Label labUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label labLoginDate;
    }
}