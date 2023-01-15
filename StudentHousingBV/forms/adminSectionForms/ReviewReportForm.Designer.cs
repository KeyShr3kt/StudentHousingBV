namespace StudentHousingBV.forms.adminSectionForms
{
    partial class ReviewReportForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblBuilding = new System.Windows.Forms.Label();
            this.lblReportingEvent = new System.Windows.Forms.Label();
            this.btnMarkAsReviewed = new System.Windows.Forms.Button();
            this.btnReportedEventInfo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(6, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(44, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.ForeColor = System.Drawing.Color.Black;
            this.lblDescription.Location = new System.Drawing.Point(6, 56);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(67, 15);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.AutoSize = true;
            this.lblCreatedAt.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedAt.Location = new System.Drawing.Point(6, 61);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(60, 15);
            this.lblCreatedAt.TabIndex = 2;
            this.lblCreatedAt.Text = "CreatedAt";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(6, 19);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(62, 15);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "UserName";
            // 
            // lblBuilding
            // 
            this.lblBuilding.AutoSize = true;
            this.lblBuilding.ForeColor = System.Drawing.Color.Black;
            this.lblBuilding.Location = new System.Drawing.Point(6, 40);
            this.lblBuilding.Name = "lblBuilding";
            this.lblBuilding.Size = new System.Drawing.Size(51, 15);
            this.lblBuilding.TabIndex = 4;
            this.lblBuilding.Text = "Building";
            // 
            // lblReportingEvent
            // 
            this.lblReportingEvent.AutoSize = true;
            this.lblReportingEvent.ForeColor = System.Drawing.Color.Black;
            this.lblReportingEvent.Location = new System.Drawing.Point(6, 19);
            this.lblReportingEvent.Name = "lblReportingEvent";
            this.lblReportingEvent.Size = new System.Drawing.Size(59, 15);
            this.lblReportingEvent.TabIndex = 5;
            this.lblReportingEvent.Text = "Reporting";
            // 
            // btnMarkAsReviewed
            // 
            this.btnMarkAsReviewed.BackColor = System.Drawing.Color.White;
            this.btnMarkAsReviewed.Location = new System.Drawing.Point(134, 289);
            this.btnMarkAsReviewed.Name = "btnMarkAsReviewed";
            this.btnMarkAsReviewed.Size = new System.Drawing.Size(207, 23);
            this.btnMarkAsReviewed.TabIndex = 6;
            this.btnMarkAsReviewed.Text = "Mark as Reviewed";
            this.btnMarkAsReviewed.UseVisualStyleBackColor = false;
            this.btnMarkAsReviewed.Click += new System.EventHandler(this.btnMarkAsReviewed_Click);
            // 
            // btnReportedEventInfo
            // 
            this.btnReportedEventInfo.BackColor = System.Drawing.SystemColors.Control;
            this.btnReportedEventInfo.ForeColor = System.Drawing.Color.Black;
            this.btnReportedEventInfo.Location = new System.Drawing.Point(123, 47);
            this.btnReportedEventInfo.Name = "btnReportedEventInfo";
            this.btnReportedEventInfo.Size = new System.Drawing.Size(71, 23);
            this.btnReportedEventInfo.TabIndex = 7;
            this.btnReportedEventInfo.Text = "More info ";
            this.btnReportedEventInfo.UseVisualStyleBackColor = false;
            this.btnReportedEventInfo.Click += new System.EventHandler(this.btnReportedEventInfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 186);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCreatedAt);
            this.groupBox2.Controls.Add(this.lblUserName);
            this.groupBox2.Controls.Add(this.lblBuilding);
            this.groupBox2.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox2.Location = new System.Drawing.Point(12, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 79);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sender";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblReportingEvent);
            this.groupBox3.Controls.Add(this.btnReportedEventInfo);
            this.groupBox3.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox3.Location = new System.Drawing.Point(276, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 79);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reporting event";
            // 
            // ReviewReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 326);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMarkAsReviewed);
            this.Name = "ReviewReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Review Report";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblTitle;
        private Label lblDescription;
        private Label lblCreatedAt;
        private Label lblUserName;
        private Label lblBuilding;
        private Label lblReportingEvent;
        private Button btnMarkAsReviewed;
        private Button btnReportedEventInfo;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}