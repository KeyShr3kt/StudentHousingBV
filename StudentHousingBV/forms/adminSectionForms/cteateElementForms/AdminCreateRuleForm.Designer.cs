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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Building:";
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxTitle.Location = new System.Drawing.Point(91, 26);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(242, 23);
            this.txtBoxTitle.TabIndex = 3;
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxDescription.Location = new System.Drawing.Point(91, 62);
            this.txtBoxDescription.Multiline = true;
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(242, 128);
            this.txtBoxDescription.TabIndex = 4;
            // 
            // cmbBoxBuildings
            // 
            this.cmbBoxBuildings.FormattingEnabled = true;
            this.cmbBoxBuildings.Location = new System.Drawing.Point(91, 33);
            this.cmbBoxBuildings.Name = "cmbBoxBuildings";
            this.cmbBoxBuildings.Size = new System.Drawing.Size(242, 23);
            this.cmbBoxBuildings.TabIndex = 5;
            // 
            // lblTitleForm
            // 
            this.lblTitleForm.AutoSize = true;
            this.lblTitleForm.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleForm.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitleForm.Location = new System.Drawing.Point(12, 26);
            this.lblTitleForm.Name = "lblTitleForm";
            this.lblTitleForm.Size = new System.Drawing.Size(125, 22);
            this.lblTitleForm.TabIndex = 6;
            this.lblTitleForm.Text = "Rule Creation";
            // 
            // btnCreateRule
            // 
            this.btnCreateRule.Location = new System.Drawing.Point(263, 388);
            this.btnCreateRule.Name = "btnCreateRule";
            this.btnCreateRule.Size = new System.Drawing.Size(103, 27);
            this.btnCreateRule.TabIndex = 7;
            this.btnCreateRule.Text = "Create";
            this.btnCreateRule.UseVisualStyleBackColor = true;
            this.btnCreateRule.Click += new System.EventHandler(this.btnCreateRule_Click);
            // 
            // lblHiddenRuleId
            // 
            this.lblHiddenRuleId.AutoSize = true;
            this.lblHiddenRuleId.Location = new System.Drawing.Point(18, 400);
            this.lblHiddenRuleId.Name = "lblHiddenRuleId";
            this.lblHiddenRuleId.Size = new System.Drawing.Size(40, 15);
            this.lblHiddenRuleId.TabIndex = 8;
            this.lblHiddenRuleId.Text = "RuleId";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBoxTitle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxDescription);
            this.groupBox1.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 206);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rule Details:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbBoxBuildings);
            this.groupBox2.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox2.Location = new System.Drawing.Point(12, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 84);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "House Details";
            // 
            // AdminCreateRuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 426);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblHiddenRuleId);
            this.Controls.Add(this.btnCreateRule);
            this.Controls.Add(this.lblTitleForm);
            this.Name = "AdminCreateRuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminCreateRuleForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}