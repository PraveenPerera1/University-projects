namespace Ahead_Life
{
    partial class LoginDividerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginDividerForm));
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonEmpLogin = new System.Windows.Forms.Button();
            this.buttonAdminLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUserID.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxUserID.Location = new System.Drawing.Point(279, 173);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(243, 20);
            this.textBoxUserID.TabIndex = 0;
            this.textBoxUserID.Text = "USER ID";
            this.textBoxUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxUserID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxPassword.Location = new System.Drawing.Point(279, 233);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(243, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Text = "PASSWORD";
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonEmpLogin
            // 
            this.buttonEmpLogin.Location = new System.Drawing.Point(199, 294);
            this.buttonEmpLogin.Name = "buttonEmpLogin";
            this.buttonEmpLogin.Size = new System.Drawing.Size(120, 41);
            this.buttonEmpLogin.TabIndex = 2;
            this.buttonEmpLogin.Text = "LOGIN";
            this.buttonEmpLogin.UseVisualStyleBackColor = true;
            this.buttonEmpLogin.Click += new System.EventHandler(this.buttonEmpLogin_Click);
            // 
            // buttonAdminLogin
            // 
            this.buttonAdminLogin.Location = new System.Drawing.Point(480, 294);
            this.buttonAdminLogin.Name = "buttonAdminLogin";
            this.buttonAdminLogin.Size = new System.Drawing.Size(120, 41);
            this.buttonAdminLogin.TabIndex = 3;
            this.buttonAdminLogin.Text = "LOGIN AS ADMIN";
            this.buttonAdminLogin.UseVisualStyleBackColor = true;
            this.buttonAdminLogin.Click += new System.EventHandler(this.buttonAdminLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(315, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // LoginDividerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonAdminLogin);
            this.Controls.Add(this.buttonEmpLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserID);
            this.Name = "LoginDividerForm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonEmpLogin;
        private System.Windows.Forms.Button buttonAdminLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}