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
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.lblTaskIdHidden = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(8, 45);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(641, 48);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Task description";
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(8, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(523, 19);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "label1";
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(714, 45);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTask.TabIndex = 2;
            this.btnDeleteTask.Text = "Delete";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(714, 16);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(75, 23);
            this.btnComplete.TabIndex = 3;
            this.btnComplete.Text = "Review";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.AutoSize = true;
            this.lblCreatedAt.Location = new System.Drawing.Point(537, 16);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(38, 15);
            this.lblCreatedAt.TabIndex = 4;
            this.lblCreatedAt.Text = "label1";
            // 
            // lblTaskIdHidden
            // 
            this.lblTaskIdHidden.AutoSize = true;
            this.lblTaskIdHidden.Location = new System.Drawing.Point(654, 21);
            this.lblTaskIdHidden.Name = "lblTaskIdHidden";
            this.lblTaskIdHidden.Size = new System.Drawing.Size(38, 15);
            this.lblTaskIdHidden.TabIndex = 5;
            this.lblTaskIdHidden.Text = "label1";
            // 
            // AdminTaskComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTaskIdHidden);
            this.Controls.Add(this.lblCreatedAt);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDescription);
            this.Name = "AdminTaskComponent";
            this.Size = new System.Drawing.Size(798, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDescription;
        private Label lblTitle;
        private Button btnDeleteTask;
        private Button btnComplete;
        private Label lblCreatedAt;
        private Label lblTaskIdHidden;
    }
}
