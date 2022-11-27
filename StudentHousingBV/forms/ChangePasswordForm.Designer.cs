namespace StudentHousingBV.forms
{
    partial class ChangePasswordForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxNewPassword = new System.Windows.Forms.TextBox();
            this.txtBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(139, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(95, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "New password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(95, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm password:";
            // 
            // txtBoxNewPassword
            // 
            this.txtBoxNewPassword.Location = new System.Drawing.Point(95, 170);
            this.txtBoxNewPassword.Name = "txtBoxNewPassword";
            this.txtBoxNewPassword.Size = new System.Drawing.Size(441, 39);
            this.txtBoxNewPassword.TabIndex = 3;
            // 
            // txtBoxConfirmPassword
            // 
            this.txtBoxConfirmPassword.Location = new System.Drawing.Point(95, 285);
            this.txtBoxConfirmPassword.Name = "txtBoxConfirmPassword";
            this.txtBoxConfirmPassword.Size = new System.Drawing.Size(441, 39);
            this.txtBoxConfirmPassword.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Black", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(221, 349);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(179, 57);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(636, 473);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBoxConfirmPassword);
            this.Controls.Add(this.txtBoxNewPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBoxNewPassword;
        private TextBox txtBoxConfirmPassword;
        private Button btnSave;
    }
}