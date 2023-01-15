namespace StudentHousingBV.forms.adminSectionForms
{
    partial class AdminReportsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBtnForReview = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisableFilters = new System.Windows.Forms.Button();
            this.cmbBoxBuildings = new System.Windows.Forms.ComboBox();
            this.btnApplyFilters = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.flPanelReports = new System.Windows.Forms.FlowLayoutPanel();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtnForReview);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDisableFilters);
            this.groupBox1.Controls.Add(this.cmbBoxBuildings);
            this.groupBox1.Controls.Add(this.btnApplyFilters);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Location = new System.Drawing.Point(25, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 116);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by:";
            // 
            // rdBtnForReview
            // 
            this.rdBtnForReview.AutoSize = true;
            this.rdBtnForReview.ForeColor = System.Drawing.Color.Black;
            this.rdBtnForReview.Location = new System.Drawing.Point(108, 59);
            this.rdBtnForReview.Name = "rdBtnForReview";
            this.rdBtnForReview.Size = new System.Drawing.Size(79, 19);
            this.rdBtnForReview.TabIndex = 9;
            this.rdBtnForReview.TabStop = true;
            this.rdBtnForReview.Text = "For review";
            this.rdBtnForReview.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Status:";
            // 
            // btnDisableFilters
            // 
            this.btnDisableFilters.ForeColor = System.Drawing.Color.Black;
            this.btnDisableFilters.Location = new System.Drawing.Point(430, 87);
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
            this.cmbBoxBuildings.Size = new System.Drawing.Size(416, 23);
            this.cmbBoxBuildings.TabIndex = 7;
            // 
            // btnApplyFilters
            // 
            this.btnApplyFilters.ForeColor = System.Drawing.Color.Black;
            this.btnApplyFilters.Location = new System.Drawing.Point(319, 87);
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
            // flPanelReports
            // 
            this.flPanelReports.AutoScroll = true;
            this.flPanelReports.Location = new System.Drawing.Point(25, 192);
            this.flPanelReports.Name = "flPanelReports";
            this.flPanelReports.Size = new System.Drawing.Size(818, 462);
            this.flPanelReports.TabIndex = 10;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(25, 163);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.PlaceholderText = "Search";
            this.txtBoxSearch.Size = new System.Drawing.Size(300, 23);
            this.txtBoxSearch.TabIndex = 12;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // AdminReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 622);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flPanelReports);
            this.MaximumSize = new System.Drawing.Size(859, 661);
            this.MinimumSize = new System.Drawing.Size(859, 661);
            this.Name = "AdminReportsForm";
            this.Text = "Reports Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox1;
        private RadioButton rdBtnForReview;
        private Label label1;
        private Button btnDisableFilters;
        private ComboBox cmbBoxBuildings;
        private Button btnApplyFilters;
        private Label label2;
        private FlowLayoutPanel flPanelReports;
        private TextBox txtBoxSearch;
    }
}