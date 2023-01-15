namespace StudentHousingBV.forms.adminSectionForms
{
    partial class AdminRulesForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDisableFilters = new System.Windows.Forms.Button();
            this.cmbBoxBuildings = new System.Windows.Forms.ComboBox();
            this.btnApplyFilters = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCreateRule = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 152);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(806, 507);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDisableFilters);
            this.groupBox1.Controls.Add(this.cmbBoxBuildings);
            this.groupBox1.Controls.Add(this.btnApplyFilters);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Location = new System.Drawing.Point(25, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 98);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by:";
            // 
            // btnDisableFilters
            // 
            this.btnDisableFilters.ForeColor = System.Drawing.Color.Black;
            this.btnDisableFilters.Location = new System.Drawing.Point(351, 64);
            this.btnDisableFilters.Name = "btnDisableFilters";
            this.btnDisableFilters.Size = new System.Drawing.Size(94, 22);
            this.btnDisableFilters.TabIndex = 6;
            this.btnDisableFilters.Text = "Refresh";
            this.btnDisableFilters.UseVisualStyleBackColor = true;
            this.btnDisableFilters.Click += new System.EventHandler(this.btnDisableFilters_Click);
            // 
            // cmbBoxBuildings
            // 
            this.cmbBoxBuildings.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBoxBuildings.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBoxBuildings.FormattingEnabled = true;
            this.cmbBoxBuildings.Items.AddRange(new object[] {
            "",
            "ivan",
            "petar",
            "stanislav",
            "martin",
            "ivan2",
            "ivan3"});
            this.cmbBoxBuildings.Location = new System.Drawing.Point(108, 25);
            this.cmbBoxBuildings.Name = "cmbBoxBuildings";
            this.cmbBoxBuildings.Size = new System.Drawing.Size(239, 23);
            this.cmbBoxBuildings.TabIndex = 7;
            // 
            // btnApplyFilters
            // 
            this.btnApplyFilters.ForeColor = System.Drawing.Color.Black;
            this.btnApplyFilters.Location = new System.Drawing.Point(242, 64);
            this.btnApplyFilters.Name = "btnApplyFilters";
            this.btnApplyFilters.Size = new System.Drawing.Size(94, 22);
            this.btnApplyFilters.TabIndex = 2;
            this.btnApplyFilters.Text = "Apply";
            this.btnApplyFilters.UseVisualStyleBackColor = true;
            this.btnApplyFilters.Click += new System.EventHandler(this.btnApplyFilters_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Building:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCreateRule);
            this.groupBox2.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox2.Location = new System.Drawing.Point(526, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 98);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "More options";
            // 
            // btnCreateRule
            // 
            this.btnCreateRule.ForeColor = System.Drawing.Color.Black;
            this.btnCreateRule.Image = global::StudentHousingBV.Properties.Resources.icons8_create_24;
            this.btnCreateRule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateRule.Location = new System.Drawing.Point(17, 22);
            this.btnCreateRule.Name = "btnCreateRule";
            this.btnCreateRule.Size = new System.Drawing.Size(129, 36);
            this.btnCreateRule.TabIndex = 1;
            this.btnCreateRule.Text = "Create Rule";
            this.btnCreateRule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateRule.UseVisualStyleBackColor = true;
            this.btnCreateRule.Click += new System.EventHandler(this.btnCreateRule_Click);
            // 
            // AdminRulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(859, 661);
            this.MinimumSize = new System.Drawing.Size(859, 661);
            this.Name = "AdminRulesForm";
            this.Text = "Rules Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox1;
        private Button btnDisableFilters;
        private ComboBox cmbBoxBuildings;
        private Button btnApplyFilters;
        private Label label2;
        private GroupBox groupBox2;
        private Button btnCreateRule;
    }
}