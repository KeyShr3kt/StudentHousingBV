namespace StudentHousingBV.forms.components
{
    partial class TaskComponent
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
            this.TaskDescriptionLabel = new System.Windows.Forms.Label();
            this.TaskUserLabel = new System.Windows.Forms.Label();
            this.TaskMarkAsDoneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TaskDescriptionLabel
            // 
            this.TaskDescriptionLabel.AutoSize = true;
            this.TaskDescriptionLabel.Location = new System.Drawing.Point(23, 28);
            this.TaskDescriptionLabel.Name = "TaskDescriptionLabel";
            this.TaskDescriptionLabel.Size = new System.Drawing.Size(74, 15);
            this.TaskDescriptionLabel.TabIndex = 0;
            this.TaskDescriptionLabel.Text = "{description}";
            // 
            // TaskUserLabel
            // 
            this.TaskUserLabel.AutoSize = true;
            this.TaskUserLabel.Location = new System.Drawing.Point(451, 28);
            this.TaskUserLabel.Name = "TaskUserLabel";
            this.TaskUserLabel.Size = new System.Drawing.Size(37, 15);
            this.TaskUserLabel.TabIndex = 1;
            this.TaskUserLabel.Text = "{user}";
            // 
            // TaskMarkAsDoneButton
            // 
            this.TaskMarkAsDoneButton.Location = new System.Drawing.Point(763, 24);
            this.TaskMarkAsDoneButton.Name = "TaskMarkAsDoneButton";
            this.TaskMarkAsDoneButton.Size = new System.Drawing.Size(127, 23);
            this.TaskMarkAsDoneButton.TabIndex = 4;
            this.TaskMarkAsDoneButton.Text = "Mark as done";
            this.TaskMarkAsDoneButton.UseVisualStyleBackColor = true;
            // 
            // TaskComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TaskMarkAsDoneButton);
            this.Controls.Add(this.TaskUserLabel);
            this.Controls.Add(this.TaskDescriptionLabel);
            this.Name = "TaskComponent";
            this.Size = new System.Drawing.Size(914, 72);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TaskDescriptionLabel;
        private Label TaskUserLabel;
        private Button TaskMarkAsDoneButton;
    }
}
