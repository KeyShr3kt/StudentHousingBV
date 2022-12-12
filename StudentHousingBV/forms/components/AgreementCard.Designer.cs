namespace StudentHousingBV.forms.components
{
    partial class AgreementCard
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.linkMore = new System.Windows.Forms.LinkLabel();
            this.lblUpvote = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDownvote = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVote = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(13, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(71, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Agreement";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(3, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(153, 15);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Lorem ipsum dolor sit amet";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblDescription);
            this.flowLayoutPanel1.Controls.Add(this.linkMore);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(791, 56);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // linkMore
            // 
            this.linkMore.AutoSize = true;
            this.linkMore.Location = new System.Drawing.Point(162, 0);
            this.linkMore.Name = "linkMore";
            this.linkMore.Size = new System.Drawing.Size(44, 15);
            this.linkMore.TabIndex = 4;
            this.linkMore.TabStop = true;
            this.linkMore.Text = "...more";
            this.linkMore.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMore_LinkClicked);
            // 
            // lblUpvote
            // 
            this.lblUpvote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUpvote.AutoSize = true;
            this.lblUpvote.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUpvote.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblUpvote.Location = new System.Drawing.Point(3, 0);
            this.lblUpvote.Name = "lblUpvote";
            this.lblUpvote.Size = new System.Drawing.Size(22, 25);
            this.lblUpvote.TabIndex = 5;
            this.lblUpvote.Text = "6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "/";
            // 
            // lblDownvote
            // 
            this.lblDownvote.AutoSize = true;
            this.lblDownvote.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDownvote.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblDownvote.Location = new System.Drawing.Point(56, 0);
            this.lblDownvote.Name = "lblDownvote";
            this.lblDownvote.Size = new System.Drawing.Size(22, 25);
            this.lblDownvote.TabIndex = 7;
            this.lblDownvote.Text = "9";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.lblUpvote);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.lblDownvote);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(810, 30);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(87, 25);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // btnVote
            // 
            this.btnVote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVote.Location = new System.Drawing.Point(811, 65);
            this.btnVote.Name = "btnVote";
            this.btnVote.Size = new System.Drawing.Size(75, 23);
            this.btnVote.TabIndex = 9;
            this.btnVote.Text = "Vote";
            this.btnVote.UseVisualStyleBackColor = true;
            this.btnVote.Click += new System.EventHandler(this.btnVote_Click);
            // 
            // AgreementCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnVote);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblTitle);
            this.Name = "AgreementCard";
            this.Size = new System.Drawing.Size(900, 95);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Label lblDescription;
        private FlowLayoutPanel flowLayoutPanel1;
        private LinkLabel linkMore;
        private Label lblUpvote;
        private Label label2;
        private Label lblDownvote;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnVote;
    }
}
