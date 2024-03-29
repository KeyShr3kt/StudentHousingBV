﻿namespace StudentHousingBV.forms
{
    partial class CompletePaymentForm
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
            this.AddPictureLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddPictureLabel
            // 
            this.AddPictureLabel.AutoSize = true;
            this.AddPictureLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.AddPictureLabel.Location = new System.Drawing.Point(94, 82);
            this.AddPictureLabel.Name = "AddPictureLabel";
            this.AddPictureLabel.Size = new System.Drawing.Size(93, 21);
            this.AddPictureLabel.TabIndex = 1;
            this.AddPictureLabel.Text = "Add picture";
            this.AddPictureLabel.Click += new System.EventHandler(this.AddPictureLabel_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(108, 46);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(136, 23);
            this.PriceTextBox.TabIndex = 2;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(38, 49);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(64, 15);
            this.PriceLabel.TabIndex = 3;
            this.PriceLabel.Text = "Total price:";
            // 
            // SendButton
            // 
            this.SendButton.Enabled = false;
            this.SendButton.Location = new System.Drawing.Point(65, 142);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(144, 29);
            this.SendButton.TabIndex = 4;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // CompletePaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 231);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.AddPictureLabel);
            this.Name = "CompletePaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complete Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label AddPictureLabel;
        private OpenFileDialog openFileDialog;
        private TextBox PriceTextBox;
        private Label PriceLabel;
        private Button SendButton;
    }
}