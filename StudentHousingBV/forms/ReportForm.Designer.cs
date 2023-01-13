namespace StudentHousingBV.forms
{
    partial class ReportForm
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
            this.lbReportedEvent = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "REPORT";
            // 
            // lbReportedEvent
            // 
            this.lbReportedEvent.AutoSize = true;
            this.lbReportedEvent.Location = new System.Drawing.Point(11, 63);
            this.lbReportedEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbReportedEvent.Name = "lbReportedEvent";
            this.lbReportedEvent.Size = new System.Drawing.Size(133, 15);
            this.lbReportedEvent.TabIndex = 1;
            this.lbReportedEvent.Text = "Event reported: #ID Title";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(11, 119);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbDescription.MinimumSize = new System.Drawing.Size(379, 143);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(436, 143);
            this.tbDescription.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(188, 280);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(81, 22);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Complete";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 339);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lbReportedEvent);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "ReportForm";
            this.Text = "Student Housing BV - Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lbReportedEvent;
        private TextBox tbDescription;
        private Label label3;
        private Button btnSend;
    }
}