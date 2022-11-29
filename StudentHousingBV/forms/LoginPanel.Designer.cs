namespace StudentHousingBV.forms
{
    partial class LoginPanel
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
            this.LoginEmailLabel = new System.Windows.Forms.Label();
            this.LoginPasswordLabel = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.LoginWelcomeLabel = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.LoginLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoginLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginEmailLabel
            // 
            this.LoginEmailLabel.AutoSize = true;
            this.LoginEmailLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginEmailLabel.ForeColor = System.Drawing.Color.Brown;
            this.LoginEmailLabel.Location = new System.Drawing.Point(106, 226);
            this.LoginEmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginEmailLabel.Name = "LoginEmailLabel";
            this.LoginEmailLabel.Size = new System.Drawing.Size(39, 15);
            this.LoginEmailLabel.TabIndex = 0;
            this.LoginEmailLabel.Text = "Email:";
            // 
            // LoginPasswordLabel
            // 
            this.LoginPasswordLabel.AutoSize = true;
            this.LoginPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginPasswordLabel.ForeColor = System.Drawing.Color.Brown;
            this.LoginPasswordLabel.Location = new System.Drawing.Point(106, 286);
            this.LoginPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginPasswordLabel.Name = "LoginPasswordLabel";
            this.LoginPasswordLabel.Size = new System.Drawing.Size(62, 15);
            this.LoginPasswordLabel.TabIndex = 1;
            this.LoginPasswordLabel.Text = "Password:";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(106, 242);
            this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(247, 23);
            this.txtBoxEmail.TabIndex = 2;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(106, 302);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(247, 23);
            this.txtBoxPassword.TabIndex = 3;
            // 
            // LoginWelcomeLabel
            // 
            this.LoginWelcomeLabel.AutoSize = true;
            this.LoginWelcomeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginWelcomeLabel.ForeColor = System.Drawing.Color.Brown;
            this.LoginWelcomeLabel.Location = new System.Drawing.Point(173, 185);
            this.LoginWelcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginWelcomeLabel.Name = "LoginWelcomeLabel";
            this.LoginWelcomeLabel.Size = new System.Drawing.Size(122, 30);
            this.LoginWelcomeLabel.TabIndex = 4;
            this.LoginWelcomeLabel.Text = "WELCOME!";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Brown;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(149, 347);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(166, 29);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginLogo
            // 
            this.LoginLogo.Image = global::StudentHousingBV.Properties.Resources.project_modified;
            this.LoginLogo.InitialImage = global::StudentHousingBV.Properties.Resources.project_modified;
            this.LoginLogo.Location = new System.Drawing.Point(149, 28);
            this.LoginLogo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.LoginLogo.Name = "LoginLogo";
            this.LoginLogo.Size = new System.Drawing.Size(166, 132);
            this.LoginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoginLogo.TabIndex = 6;
            this.LoginLogo.TabStop = false;
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(458, 418);
            this.Controls.Add(this.LoginWelcomeLabel);
            this.Controls.Add(this.LoginLogo);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.LoginPasswordLabel);
            this.Controls.Add(this.LoginEmailLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "LoginPanel";
            this.Text = "Student Housing BV - Login";
            ((System.ComponentModel.ISupportInitialize)(this.LoginLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LoginEmailLabel;
        private Label LoginPasswordLabel;
        private TextBox txtBoxEmail;
        private TextBox txtBoxPassword;
        private Label LoginWelcomeLabel;
        private Button btnLogin;
        private PictureBox LoginLogo;
    }
}