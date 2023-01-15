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
            this.lbTaskDescription = new System.Windows.Forms.Label();
            this.lbTaskUser = new System.Windows.Forms.Label();
            this.btnTaskComponent = new System.Windows.Forms.Button();
            this.btnReportTask = new StudentHousingBV.forms.RoundButton();
            this.SuspendLayout();
            // 
            // lbTaskDescription
            // 
            this.lbTaskDescription.AutoSize = true;
            this.lbTaskDescription.Location = new System.Drawing.Point(39, 28);
            this.lbTaskDescription.Name = "lbTaskDescription";
            this.lbTaskDescription.Size = new System.Drawing.Size(74, 15);
            this.lbTaskDescription.TabIndex = 0;
            this.lbTaskDescription.Text = "{description}";
            // 
            // lbTaskUser
            // 
            this.lbTaskUser.AutoSize = true;
            this.lbTaskUser.Location = new System.Drawing.Point(442, 28);
            this.lbTaskUser.Name = "lbTaskUser";
            this.lbTaskUser.Size = new System.Drawing.Size(37, 15);
            this.lbTaskUser.TabIndex = 1;
            this.lbTaskUser.Text = "{user}";
            // 
            // btnTaskComponent
            // 
            this.btnTaskComponent.Enabled = false;
            this.btnTaskComponent.Location = new System.Drawing.Point(722, 24);
            this.btnTaskComponent.Name = "btnTaskComponent";
            this.btnTaskComponent.Size = new System.Drawing.Size(127, 23);
            this.btnTaskComponent.TabIndex = 4;
            this.btnTaskComponent.Text = "Open details";
            this.btnTaskComponent.UseVisualStyleBackColor = true;
            this.btnTaskComponent.Click += new System.EventHandler(this.btnTaskComponent_Click);
            // 
            // btnReportTask
            // 
            this.btnReportTask.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReportTask.ForeColor = System.Drawing.Color.Red;
            this.btnReportTask.Location = new System.Drawing.Point(855, 22);
            this.btnReportTask.Name = "btnReportTask";
            this.btnReportTask.Size = new System.Drawing.Size(25, 25);
            this.btnReportTask.TabIndex = 5;
            this.btnReportTask.Text = "!";
            this.btnReportTask.UseVisualStyleBackColor = true;
            this.btnReportTask.Click += new System.EventHandler(this.btnReportTask_Click);
            // 
            // TaskComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReportTask);
            this.Controls.Add(this.btnTaskComponent);
            this.Controls.Add(this.lbTaskUser);
            this.Controls.Add(this.lbTaskDescription);
            this.Name = "TaskComponent";
            this.Size = new System.Drawing.Size(914, 72);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTaskDescription;
        private Label lbTaskUser;
        private Button btnTaskComponent;
        private RoundButton btnReportTask;
    }
}
