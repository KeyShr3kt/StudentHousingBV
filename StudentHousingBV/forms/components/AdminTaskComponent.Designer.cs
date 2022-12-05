namespace StudentHousingBV.forms.components
{
    partial class AdminTaskComponent
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
            this.lblTaskDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTaskDescription
            // 
            this.lblTaskDescription.AutoSize = true;
            this.lblTaskDescription.Location = new System.Drawing.Point(17, 13);
            this.lblTaskDescription.Name = "lblTaskDescription";
            this.lblTaskDescription.Size = new System.Drawing.Size(91, 15);
            this.lblTaskDescription.TabIndex = 0;
            this.lblTaskDescription.Text = "Task description";
            // 
            // AdminTaskComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.lblTaskDescription);
            this.Name = "AdminTaskComponent";
            this.Size = new System.Drawing.Size(818, 82);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTaskDescription;
    }
}
