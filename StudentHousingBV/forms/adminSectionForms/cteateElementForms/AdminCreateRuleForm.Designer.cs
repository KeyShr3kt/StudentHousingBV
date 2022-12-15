namespace StudentHousingBV.forms.adminSectionForms
{
    partial class AdminCreateRuleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.cmbBoxBuildings = new System.Windows.Forms.ComboBox();
            this.lblTitleForm = new System.Windows.Forms.Label();
            this.btnCreateRule = new System.Windows.Forms.Button();
            this.lblHiddenRuleId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "For building:";
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(293, 144);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(322, 23);
            this.txtBoxTitle.TabIndex = 3;
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Location = new System.Drawing.Point(293, 196);
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(322, 23);
            this.txtBoxDescription.TabIndex = 4;
            // 
            // cmbBoxBuildings
            // 
            this.cmbBoxBuildings.FormattingEnabled = true;
            this.cmbBoxBuildings.Location = new System.Drawing.Point(293, 241);
            this.cmbBoxBuildings.Name = "cmbBoxBuildings";
            this.cmbBoxBuildings.Size = new System.Drawing.Size(322, 23);
            this.cmbBoxBuildings.TabIndex = 5;
            // 
            // lblTitleForm
            // 
            this.lblTitleForm.AutoSize = true;
            this.lblTitleForm.Location = new System.Drawing.Point(336, 67);
            this.lblTitleForm.Name = "lblTitleForm";
            this.lblTitleForm.Size = new System.Drawing.Size(76, 15);
            this.lblTitleForm.TabIndex = 6;
            this.lblTitleForm.Text = "Create a rule:";
            // 
            // btnCreateRule
            // 
            this.btnCreateRule.Location = new System.Drawing.Point(302, 319);
            this.btnCreateRule.Name = "btnCreateRule";
            this.btnCreateRule.Size = new System.Drawing.Size(131, 31);
            this.btnCreateRule.TabIndex = 7;
            this.btnCreateRule.Text = "Create";
            this.btnCreateRule.UseVisualStyleBackColor = true;
            this.btnCreateRule.Click += new System.EventHandler(this.btnCreateRule_Click);
            // 
            // lblHiddenRuleId
            // 
            this.lblHiddenRuleId.AutoSize = true;
            this.lblHiddenRuleId.Location = new System.Drawing.Point(611, 75);
            this.lblHiddenRuleId.Name = "lblHiddenRuleId";
            this.lblHiddenRuleId.Size = new System.Drawing.Size(38, 15);
            this.lblHiddenRuleId.TabIndex = 8;
            this.lblHiddenRuleId.Text = "label4";
            // 
            // AdminCreateRuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHiddenRuleId);
            this.Controls.Add(this.btnCreateRule);
            this.Controls.Add(this.lblTitleForm);
            this.Controls.Add(this.cmbBoxBuildings);
            this.Controls.Add(this.txtBoxDescription);
            this.Controls.Add(this.txtBoxTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminCreateRuleForm";
            this.Text = "AdminCreateRuleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBoxTitle;
        private TextBox txtBoxDescription;
        private ComboBox cmbBoxBuildings;
        private Label lblTitleForm;
        private Button btnCreateRule;
        private Label lblHiddenRuleId;
    }
}