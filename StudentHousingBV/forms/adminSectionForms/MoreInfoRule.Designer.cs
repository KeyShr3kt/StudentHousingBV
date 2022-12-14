namespace StudentHousingBV.forms.adminSectionForms
{
    partial class MoreInfoRule
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
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.lblUpdatedAt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Location = new System.Drawing.Point(123, 118);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(38, 15);
            this.lblCreatedBy.TabIndex = 0;
            this.lblCreatedBy.Text = "label1";
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.AutoSize = true;
            this.lblCreatedAt.Location = new System.Drawing.Point(123, 154);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(38, 15);
            this.lblCreatedAt.TabIndex = 1;
            this.lblCreatedAt.Text = "label1";
            // 
            // lblUpdatedAt
            // 
            this.lblUpdatedAt.AutoSize = true;
            this.lblUpdatedAt.Location = new System.Drawing.Point(123, 205);
            this.lblUpdatedAt.Name = "lblUpdatedAt";
            this.lblUpdatedAt.Size = new System.Drawing.Size(38, 15);
            this.lblUpdatedAt.TabIndex = 2;
            this.lblUpdatedAt.Text = "label1";
            // 
            // MoreInfoRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.lblUpdatedAt);
            this.Controls.Add(this.lblCreatedAt);
            this.Controls.Add(this.lblCreatedBy);
            this.Name = "MoreInfoRule";
            this.Text = "MoreInfoRule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCreatedBy;
        private Label lblCreatedAt;
        private Label lblUpdatedAt;
    }
}