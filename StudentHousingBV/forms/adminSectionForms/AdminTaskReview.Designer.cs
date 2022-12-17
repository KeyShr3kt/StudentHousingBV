namespace StudentHousingBV.forms.adminSectionForms
{
    partial class AdminTaskReview
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
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.lblIBAN = new System.Windows.Forms.Label();
            this.lblToPayBack = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(201, 80);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(67, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title of task";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(100, 121);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(104, 15);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "description of task";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(100, 183);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(61, 15);
            this.lblTotalPrice.TabIndex = 2;
            this.lblTotalPrice.Text = "Total price";
            // 
            // btnReceipt
            // 
            this.btnReceipt.Location = new System.Drawing.Point(372, 30);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(190, 23);
            this.btnReceipt.TabIndex = 3;
            this.btnReceipt.Text = "Evidence receipt";
            this.btnReceipt.UseVisualStyleBackColor = true;
            // 
            // lblIBAN
            // 
            this.lblIBAN.AutoSize = true;
            this.lblIBAN.Location = new System.Drawing.Point(100, 254);
            this.lblIBAN.Name = "lblIBAN";
            this.lblIBAN.Size = new System.Drawing.Size(73, 15);
            this.lblIBAN.TabIndex = 4;
            this.lblIBAN.Text = "IBAN of user";
            // 
            // lblToPayBack
            // 
            this.lblToPayBack.AutoSize = true;
            this.lblToPayBack.Location = new System.Drawing.Point(100, 221);
            this.lblToPayBack.Name = "lblToPayBack";
            this.lblToPayBack.Size = new System.Drawing.Size(69, 15);
            this.lblToPayBack.TabIndex = 5;
            this.lblToPayBack.Text = "To pay back";
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(201, 308);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(75, 23);
            this.btnComplete.TabIndex = 6;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // AdminTaskReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 464);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.lblToPayBack);
            this.Controls.Add(this.lblIBAN);
            this.Controls.Add(this.btnReceipt);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Name = "AdminTaskReview";
            this.Text = "AdminTaskReview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Label lblDescription;
        private Label lblTotalPrice;
        private Button btnReceipt;
        private Label lblIBAN;
        private Label lblToPayBack;
        private Button btnComplete;
    }
}