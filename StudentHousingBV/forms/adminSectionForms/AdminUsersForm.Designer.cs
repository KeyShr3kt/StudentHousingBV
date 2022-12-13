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
            this.label4 = new System.Windows.Forms.Label();
            this.btnSortByUpvotes = new System.Windows.Forms.Button();
            this.btnSortByDownvotes = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(6, 28);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(238, 29);
            this.btnCreateUser.TabIndex = 1;
            this.btnCreateUser.Text = "Create user";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 236);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(818, 411);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnApplyFilters
            // 
            this.btnApplyFilters.Location = new System.Drawing.Point(108, 103);
            this.btnApplyFilters.Name = "btnApplyFilters";
            this.btnApplyFilters.Size = new System.Drawing.Size(166, 32);
            this.btnApplyFilters.TabIndex = 2;
            this.btnApplyFilters.Text = "Apply filters";
            this.btnApplyFilters.UseVisualStyleBackColor = true;
            this.btnApplyFilters.Click += new System.EventHandler(this.btnApplyFilters_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Building:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Role:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxIsAdmin);
            this.groupBox1.Controls.Add(this.btnDisableFilters);
            this.groupBox1.Controls.Add(this.cmbBoxBuildings);
            this.groupBox1.Controls.Add(this.btnApplyFilters);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 141);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by:";
            // 
            // checkBoxIsAdmin
            // 
            this.checkBoxIsAdmin.AutoSize = true;
            this.checkBoxIsAdmin.Location = new System.Drawing.Point(108, 64);
            this.checkBoxIsAdmin.Name = "checkBoxIsAdmin";
            this.checkBoxIsAdmin.Size = new System.Drawing.Size(62, 19);
            this.checkBoxIsAdmin.TabIndex = 9;
            this.checkBoxIsAdmin.Text = "Admin";
            this.checkBoxIsAdmin.UseVisualStyleBackColor = true;
            // 
            // btnDisableFilters
            // 
            this.btnDisableFilters.Location = new System.Drawing.Point(358, 103);
            this.btnDisableFilters.Name = "btnDisableFilters";
            this.btnDisableFilters.Size = new System.Drawing.Size(166, 32);
            this.btnDisableFilters.TabIndex = 6;
            this.btnDisableFilters.Text = "Disable filters";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCreateUser);
            this.groupBox2.Location = new System.Drawing.Point(581, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 76);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "More options";
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(25, 207);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.PlaceholderText = "Search";
            this.txtBoxSearch.Size = new System.Drawing.Size(300, 23);
            this.txtBoxSearch.TabIndex = 8;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(623, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sort by:";
            // 
            // btnSortByUpvotes
            // 
            this.btnSortByUpvotes.Location = new System.Drawing.Point(676, 211);
            this.btnSortByUpvotes.Name = "btnSortByUpvotes";
            this.btnSortByUpvotes.Size = new System.Drawing.Size(75, 23);
            this.btnSortByUpvotes.TabIndex = 10;
            this.btnSortByUpvotes.Text = "Upvotes";
            this.btnSortByUpvotes.UseVisualStyleBackColor = true;
            this.btnSortByUpvotes.Click += new System.EventHandler(this.btnSortByUpvotes_Click);
            // 
            // btnSortByDownvotes
            // 
            this.btnSortByDownvotes.Location = new System.Drawing.Point(757, 211);
            this.btnSortByDownvotes.Name = "btnSortByDownvotes";
            this.btnSortByDownvotes.Size = new System.Drawing.Size(75, 23);
            this.btnSortByDownvotes.TabIndex = 11;
            this.btnSortByDownvotes.Text = "Downvotes";
            this.btnSortByDownvotes.UseVisualStyleBackColor = true;
            this.btnSortByDownvotes.Click += new System.EventHandler(this.btnSortByDownvotes_Click);
            // 
            // AdminUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(843, 622);
            this.Controls.Add(this.btnSortByDownvotes);
            this.Controls.Add(this.btnSortByUpvotes);
            this.Controls.Add(this.label4);
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
        private Label label4;
        private Button btnSortByUpvotes;
        private Button btnSortByDownvotes;
    }
}