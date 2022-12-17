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
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(145, 73);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(29, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(145, 126);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(67, 15);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.AutoSize = true;
            this.lblCreatedAt.Location = new System.Drawing.Point(144, 167);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(60, 15);
            this.lblCreatedAt.TabIndex = 2;
            this.lblCreatedAt.Text = "CreatedAt";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(151, 206);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(62, 15);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "UserName";
            // 
            // lblBuilding
            // 
            this.lblBuilding.AutoSize = true;
            this.lblBuilding.Location = new System.Drawing.Point(150, 250);
            this.lblBuilding.Name = "lblBuilding";
            this.lblBuilding.Size = new System.Drawing.Size(51, 15);
            this.lblBuilding.TabIndex = 4;
            this.lblBuilding.Text = "Building";
            // 
            // lblReportingEvent
            // 
            this.lblReportingEvent.AutoSize = true;
            this.lblReportingEvent.Location = new System.Drawing.Point(149, 281);
            this.lblReportingEvent.Name = "lblReportingEvent";
            this.lblReportingEvent.Size = new System.Drawing.Size(59, 15);
            this.lblReportingEvent.TabIndex = 5;
            this.lblReportingEvent.Text = "Reporting";
            // 
            // btnMarkAsReviewed
            // 
            this.btnMarkAsReviewed.Location = new System.Drawing.Point(267, 364);
            this.btnMarkAsReviewed.Name = "btnMarkAsReviewed";
            this.btnMarkAsReviewed.Size = new System.Drawing.Size(207, 23);
            this.btnMarkAsReviewed.TabIndex = 6;
            this.btnMarkAsReviewed.Text = "Mark as Reviewed";
            this.btnMarkAsReviewed.UseVisualStyleBackColor = true;
            this.btnMarkAsReviewed.Click += new System.EventHandler(this.btnMarkAsReviewed_Click);
            // 
            // btnReportedEventInfo
            // 
            this.btnReportedEventInfo.Location = new System.Drawing.Point(154, 312);
            this.btnReportedEventInfo.Name = "btnReportedEventInfo";
            this.btnReportedEventInfo.Size = new System.Drawing.Size(179, 23);
            this.btnReportedEventInfo.TabIndex = 7;
            this.btnReportedEventInfo.Text = "More info for reported event";
            this.btnReportedEventInfo.UseVisualStyleBackColor = true;
            this.btnReportedEventInfo.Click += new System.EventHandler(this.btnReportedEventInfo_Click);
            // 
            // ReviewReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReportedEventInfo);
            this.Controls.Add(this.btnMarkAsReviewed);
            this.Controls.Add(this.lblReportingEvent);
            this.Controls.Add(this.lblBuilding);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblCreatedAt);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Name = "ReviewReportForm";
            this.Text = "ReviewReportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}