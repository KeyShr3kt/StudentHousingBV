namespace StudentHousingBV.forms
{
    partial class TaskForm
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
            this.backgroundTask = new System.Windows.Forms.PictureBox();
            this.fpTaskForm = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundTask)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundTask
            // 
            this.backgroundTask.Image = global::StudentHousingBV.Properties.Resources.TUe_by_night1;
            this.backgroundTask.Location = new System.Drawing.Point(12, 12);
            this.backgroundTask.Name = "backgroundTask";
            this.backgroundTask.Size = new System.Drawing.Size(969, 155);
            this.backgroundTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundTask.TabIndex = 0;
            this.backgroundTask.TabStop = false;
            // 
            // fpTaskForm
            // 
            this.fpTaskForm.Location = new System.Drawing.Point(12, 173);
            this.fpTaskForm.Name = "fpTaskForm";
            this.fpTaskForm.Size = new System.Drawing.Size(969, 402);
            this.fpTaskForm.TabIndex = 1;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 587);
            this.Controls.Add(this.fpTaskForm);
            this.Controls.Add(this.backgroundTask);
            this.Name = "TaskForm";
            this.Text = "Student Housing BV - Task";
            ((System.ComponentModel.ISupportInitialize)(this.backgroundTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox backgroundTask;
        private FlowLayoutPanel fpTaskForm;
    }
}