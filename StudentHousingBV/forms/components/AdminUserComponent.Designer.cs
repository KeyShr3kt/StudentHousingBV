namespace StudentHousingBV.forms
{
    partial class AdminUserComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPossitiveVotes = new System.Windows.Forms.Label();
            this.lblNegativeVotes = new System.Windows.Forms.Label();
            this.lblStrikes = new System.Windows.Forms.Label();
            this.lblisAdmin = new System.Windows.Forms.Label();
            this.lblLastSeenAt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label1";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(34, 46);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(38, 15);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "label1";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(34, 61);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 15);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "label1";
            // 
            // lblPossitiveVotes
            // 
            this.lblPossitiveVotes.AutoSize = true;
            this.lblPossitiveVotes.Location = new System.Drawing.Point(200, 31);
            this.lblPossitiveVotes.Name = "lblPossitiveVotes";
            this.lblPossitiveVotes.Size = new System.Drawing.Size(38, 15);
            this.lblPossitiveVotes.TabIndex = 4;
            this.lblPossitiveVotes.Text = "label1";
            // 
            // lblNegativeVotes
            // 
            this.lblNegativeVotes.AutoSize = true;
            this.lblNegativeVotes.Location = new System.Drawing.Point(200, 46);
            this.lblNegativeVotes.Name = "lblNegativeVotes";
            this.lblNegativeVotes.Size = new System.Drawing.Size(38, 15);
            this.lblNegativeVotes.TabIndex = 5;
            this.lblNegativeVotes.Text = "label1";
            // 
            // lblStrikes
            // 
            this.lblStrikes.AutoSize = true;
            this.lblStrikes.Location = new System.Drawing.Point(200, 61);
            this.lblStrikes.Name = "lblStrikes";
            this.lblStrikes.Size = new System.Drawing.Size(38, 15);
            this.lblStrikes.TabIndex = 6;
            this.lblStrikes.Text = "label1";
            // 
            // lblisAdmin
            // 
            this.lblisAdmin.AutoSize = true;
            this.lblisAdmin.Location = new System.Drawing.Point(394, 31);
            this.lblisAdmin.Name = "lblisAdmin";
            this.lblisAdmin.Size = new System.Drawing.Size(38, 15);
            this.lblisAdmin.TabIndex = 7;
            this.lblisAdmin.Text = "label1";
            // 
            // lblLastSeenAt
            // 
            this.lblLastSeenAt.AutoSize = true;
            this.lblLastSeenAt.Location = new System.Drawing.Point(394, 61);
            this.lblLastSeenAt.Name = "lblLastSeenAt";
            this.lblLastSeenAt.Size = new System.Drawing.Size(38, 15);
            this.lblLastSeenAt.TabIndex = 8;
            this.lblLastSeenAt.Text = "label1";
            // 
            // AdminUserComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblLastSeenAt);
            this.Controls.Add(this.lblisAdmin);
            this.Controls.Add(this.lblStrikes);
            this.Controls.Add(this.lblNegativeVotes);
            this.Controls.Add(this.lblPossitiveVotes);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblName);
            this.Name = "AdminUserComponent";
            this.Size = new System.Drawing.Size(837, 105);
            this.MouseLeave += new System.EventHandler(this.AdminUserComponent_MouseLeave);
            this.MouseHover += new System.EventHandler(this.AdminUserComponent_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private Label lblPhoneNumber;
        private Label lblEmail;
        private Label lblPossitiveVotes;
        private Label lblNegativeVotes;
        private Label lblStrikes;
        private Label lblisAdmin;
        private Label lblLastSeenAt;
    }
}
