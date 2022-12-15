namespace StudentHousingBV.forms.components
{
    partial class AdminRuleComponent
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblRuleDescription = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMoreInfo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(41, 17);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblRuleDescription
            // 
            this.lblRuleDescription.Location = new System.Drawing.Point(3, 29);
            this.lblRuleDescription.Name = "lblRuleDescription";
            this.lblRuleDescription.Size = new System.Drawing.Size(605, 29);
            this.lblRuleDescription.TabIndex = 1;
            this.lblRuleDescription.Text = "description";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.lblRuleDescription);
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 58);
            this.panel1.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(3, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(38, 15);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMoreInfo);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(630, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 75);
            this.panel3.TabIndex = 7;
            // 
            // btnMoreInfo
            // 
            this.btnMoreInfo.Location = new System.Drawing.Point(41, 43);
            this.btnMoreInfo.Name = "btnMoreInfo";
            this.btnMoreInfo.Size = new System.Drawing.Size(75, 23);
            this.btnMoreInfo.TabIndex = 1;
            this.btnMoreInfo.Text = "More info";
            this.btnMoreInfo.UseVisualStyleBackColor = true;
            this.btnMoreInfo.Click += new System.EventHandler(this.btnMoreInfo_Click);
            // 
            // AdminRuleComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "AdminRuleComponent";
            this.Size = new System.Drawing.Size(790, 75);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnEdit;
        private Label lblRuleDescription;
        private Panel panel1;
        private Panel panel3;
        private Label lblTitle;
        private Button btnMoreInfo;
    }
}
