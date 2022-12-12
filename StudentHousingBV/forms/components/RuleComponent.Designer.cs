﻿namespace StudentHousingBV.forms.components
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
            this.lbRuleId = new System.Windows.Forms.Label();
            this.lbRuleTitle = new System.Windows.Forms.Label();
            this.btnReportTask = new StudentHousingBV.forms.RoundButton();
            this.SuspendLayout();
            // 
            // lbRuleId
            // 
            this.lbRuleId.AutoSize = true;
            this.lbRuleId.Location = new System.Drawing.Point(45, 29);
            this.lbRuleId.Name = "lbRuleId";
            this.lbRuleId.Size = new System.Drawing.Size(25, 15);
            this.lbRuleId.TabIndex = 0;
            this.lbRuleId.Text = "{id}";
            // 
            // lbRuleTitle
            // 
            this.lbRuleTitle.AutoSize = true;
            this.lbRuleTitle.Location = new System.Drawing.Point(159, 29);
            this.lbRuleTitle.Name = "lbRuleTitle";
            this.lbRuleTitle.Size = new System.Drawing.Size(35, 15);
            this.lbRuleTitle.TabIndex = 1;
            this.lbRuleTitle.Text = "{title}";
            // 
            // btnReportTask
            // 
            this.btnReportTask.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReportTask.ForeColor = System.Drawing.Color.Red;
            this.btnReportTask.Location = new System.Drawing.Point(856, 23);
            this.btnReportTask.Name = "btnReportTask";
            this.btnReportTask.Size = new System.Drawing.Size(25, 25);
            this.btnReportTask.TabIndex = 6;
            this.btnReportTask.Text = "!";
            this.btnReportTask.UseVisualStyleBackColor = true;
            this.btnReportTask.Click += new System.EventHandler(this.btnReportTask_Click);
            // 
            // RuleComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReportTask);
            this.Controls.Add(this.lbRuleTitle);
            this.Controls.Add(this.lbRuleId);
            this.Name = "RuleComponent";
            this.Size = new System.Drawing.Size(914, 72);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbRuleId;
        private Label lbRuleTitle;
        private RoundButton btnReportTask;
    }
}