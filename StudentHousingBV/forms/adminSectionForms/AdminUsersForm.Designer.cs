namespace StudentHousingBV.forms.adminSectionForms
{
    partial class AdminUsersForm
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
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnApplyFilters = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxIsAdmin = new System.Windows.Forms.CheckBox();
            this.btnDisableFilters = new System.Windows.Forms.Button();
            this.cmbBoxBuildings = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSortByUpvotes = new System.Windows.Forms.Button();
            this.btnSortByDownvotes = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCreateUser.ForeColor = System.Drawing.Color.Black;
            this.btnCreateUser.Image = global::StudentHousingBV.Properties.Resources.icons8_add_user_male_24;
            this.btnCreateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateUser.Location = new System.Drawing.Point(16, 25);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(149, 38);
            this.btnCreateUser.TabIndex = 1;
            this.btnCreateUser.Text = "Register New Tenant";
            this.btnCreateUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 211);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(806, 411);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnApplyFilters
            // 
            this.btnApplyFilters.ForeColor = System.Drawing.Color.Black;
            this.btnApplyFilters.Location = new System.Drawing.Point(238, 83);
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
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Building:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Administration Role:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxIsAdmin);
            this.groupBox1.Controls.Add(this.btnDisableFilters);
            this.groupBox1.Controls.Add(this.cmbBoxBuildings);
            this.groupBox1.Controls.Add(this.btnApplyFilters);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 116);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by:";
            // 
            // checkBoxIsAdmin
            // 
            this.checkBoxIsAdmin.AutoSize = true;
            this.checkBoxIsAdmin.ForeColor = System.Drawing.Color.Black;
            this.checkBoxIsAdmin.Location = new System.Drawing.Point(140, 60);
            this.checkBoxIsAdmin.Name = "checkBoxIsAdmin";
            this.checkBoxIsAdmin.Size = new System.Drawing.Size(62, 19);
            this.checkBoxIsAdmin.TabIndex = 9;
            this.checkBoxIsAdmin.Text = "Admin";
            this.checkBoxIsAdmin.UseVisualStyleBackColor = true;
            // 
            // btnDisableFilters
            // 
            this.btnDisableFilters.ForeColor = System.Drawing.Color.Black;
            this.btnDisableFilters.Location = new System.Drawing.Point(338, 83);
            this.btnDisableFilters.Name = "btnDisableFilters";
            this.btnDisableFilters.Size = new System.Drawing.Size(94, 22);
            this.btnDisableFilters.TabIndex = 6;
            this.btnDisableFilters.Text = "Refresh ";
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
            this.cmbBoxBuildings.Location = new System.Drawing.Point(140, 25);
            this.cmbBoxBuildings.Name = "cmbBoxBuildings";
            this.cmbBoxBuildings.Size = new System.Drawing.Size(239, 23);
            this.cmbBoxBuildings.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCreateUser);
            this.groupBox2.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox2.Location = new System.Drawing.Point(512, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 116);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "More options";
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(25, 182);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.PlaceholderText = "Search";
            this.txtBoxSearch.Size = new System.Drawing.Size(300, 23);
            this.txtBoxSearch.TabIndex = 8;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // btnSortByUpvotes
            // 
            this.btnSortByUpvotes.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnSortByUpvotes.BackgroundImage = global::StudentHousingBV.Properties.Resources.icons8_facebook_like_24;
            this.btnSortByUpvotes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSortByUpvotes.FlatAppearance.BorderSize = 0;
            this.btnSortByUpvotes.ForeColor = System.Drawing.Color.Black;
            this.btnSortByUpvotes.Location = new System.Drawing.Point(54, 12);
            this.btnSortByUpvotes.Name = "btnSortByUpvotes";
            this.btnSortByUpvotes.Size = new System.Drawing.Size(38, 35);
            this.btnSortByUpvotes.TabIndex = 10;
            this.btnSortByUpvotes.UseVisualStyleBackColor = false;
            this.btnSortByUpvotes.Click += new System.EventHandler(this.btnSortByUpvotes_Click);
            // 
            // btnSortByDownvotes
            // 
            this.btnSortByDownvotes.BackColor = System.Drawing.Color.MistyRose;
            this.btnSortByDownvotes.BackgroundImage = global::StudentHousingBV.Properties.Resources.icons8_thumbs_down_24__1_;
            this.btnSortByDownvotes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSortByDownvotes.FlatAppearance.BorderSize = 0;
            this.btnSortByDownvotes.ForeColor = System.Drawing.Color.Black;
            this.btnSortByDownvotes.Location = new System.Drawing.Point(98, 12);
            this.btnSortByDownvotes.Name = "btnSortByDownvotes";
            this.btnSortByDownvotes.Size = new System.Drawing.Size(37, 35);
            this.btnSortByDownvotes.TabIndex = 11;
            this.btnSortByDownvotes.UseVisualStyleBackColor = false;
            this.btnSortByDownvotes.Click += new System.EventHandler(this.btnSortByDownvotes_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSortByUpvotes);
            this.groupBox3.Controls.Add(this.btnSortByDownvotes);
            this.groupBox3.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox3.Location = new System.Drawing.Point(659, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 47);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sort By:";
            // 
            // AdminUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(843, 622);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(859, 661);
            this.MinimumSize = new System.Drawing.Size(859, 661);
            this.Name = "AdminUsersForm";
            this.Text = "AdminUsersForm";
            this.Load += new System.EventHandler(this.AdminUsersForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnCreateUser;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnApplyFilters;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Button btnDisableFilters;
        private ComboBox cmbBoxBuildings;
        private GroupBox groupBox2;
        private TextBox txtBoxSearch;
        private CheckBox checkBoxIsAdmin;
        private Button btnSortByUpvotes;
        private Button btnSortByDownvotes;
        private GroupBox groupBox3;
    }
}