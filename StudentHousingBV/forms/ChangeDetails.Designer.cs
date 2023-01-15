namespace StudentHousingBV.forms
{
    partial class ChangeDetails
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
            this.lbInfo = new System.Windows.Forms.Label();
            this.tbNewValue = new System.Windows.Forms.TextBox();
            this.btnSubmitChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(30, 25);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(93, 15);
            this.lbInfo.TabIndex = 0;
            this.lbInfo.Text = "Enter new value:";
            // 
            // tbNewValue
            // 
            this.tbNewValue.Location = new System.Drawing.Point(30, 43);
            this.tbNewValue.Name = "tbNewValue";
            this.tbNewValue.Size = new System.Drawing.Size(314, 23);
            this.tbNewValue.TabIndex = 1;
            // 
            // btnSubmitChanges
            // 
            this.btnSubmitChanges.Location = new System.Drawing.Point(30, 90);
            this.btnSubmitChanges.Name = "btnSubmitChanges";
            this.btnSubmitChanges.Size = new System.Drawing.Size(314, 23);
            this.btnSubmitChanges.TabIndex = 2;
            this.btnSubmitChanges.Text = "Submit changes";
            this.btnSubmitChanges.UseVisualStyleBackColor = true;
            this.btnSubmitChanges.Click += new System.EventHandler(this.btnSubmitChanges_Click);
            // 
            // ChangeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 151);
            this.Controls.Add(this.btnSubmitChanges);
            this.Controls.Add(this.tbNewValue);
            this.Controls.Add(this.lbInfo);
            this.Name = "ChangeDetails";
            this.Text = "Change <field>";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbInfo;
        private TextBox tbNewValue;
        private Button btnSubmitChanges;
    }
}