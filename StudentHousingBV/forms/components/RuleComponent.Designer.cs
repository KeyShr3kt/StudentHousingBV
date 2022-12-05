namespace StudentHousingBV.forms.components
{
    partial class RuleComponent
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
            this.RuleIdlabel = new System.Windows.Forms.Label();
            this.RuleTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RuleIdlabel
            // 
            this.RuleIdlabel.AutoSize = true;
            this.RuleIdlabel.Location = new System.Drawing.Point(45, 29);
            this.RuleIdlabel.Name = "RuleIdlabel";
            this.RuleIdlabel.Size = new System.Drawing.Size(25, 15);
            this.RuleIdlabel.TabIndex = 0;
            this.RuleIdlabel.Text = "{id}";
            // 
            // RuleTitleLabel
            // 
            this.RuleTitleLabel.AutoSize = true;
            this.RuleTitleLabel.Location = new System.Drawing.Point(159, 29);
            this.RuleTitleLabel.Name = "RuleTitleLabel";
            this.RuleTitleLabel.Size = new System.Drawing.Size(35, 15);
            this.RuleTitleLabel.TabIndex = 1;
            this.RuleTitleLabel.Text = "{title}";
            // 
            // RuleComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RuleTitleLabel);
            this.Controls.Add(this.RuleIdlabel);
            this.Name = "RuleComponent";
            this.Size = new System.Drawing.Size(914, 72);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label RuleIdlabel;
        private Label RuleTitleLabel;
    }
}
