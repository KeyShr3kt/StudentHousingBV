namespace StudentHousingBV.forms.adminSectionForms
{
    partial class AdminTasksForm
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
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBtnCompleted = new System.Windows.Forms.RadioButton();
            this.rdBtnForReview = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisableFilters = new System.Windows.Forms.Button();
            this.cmbBoxBuildings = new System.Windows.Forms.ComboBox();
            this.btnApplyFilters = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 165);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(806, 513);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.ForeColor = System.Drawing.Color.Black;
            this.btnCreateTask.Image = global::StudentHousingBV.Properties.Resources.icons8_create_24__1_;
            this.btnCreateTask.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCreateTask.Location = new System.Drawing.Point(24, 28);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(112, 35);
            this.btnCreateTask.TabIndex = 2;
            this.btnCreateTask.Text = "Create Task";
            this.btnCreateTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateTask.UseVisualStyleBackColor = true;
            this.btnCreateTask.Click += new System.EventHandler(this.btnCreateTask_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtnCompleted);
            this.groupBox1.Controls.Add(this.rdBtnForReview);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDisableFilters);
            this.groupBox1.Controls.Add(this.cmbBoxBuildings);
            this.groupBox1.Controls.Add(this.btnApplyFilters);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Location = new System.Drawing.Point(25, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 117);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by:";
            // 
            // rdBtnCompleted
            // 
            this.rdBtnCompleted.AutoSize = true;
            this.rdBtnCompleted.ForeColor = System.Drawing.Color.Black;
            this.rdBtnCompleted.Location = new System.Drawing.Point(193, 59);
            this.rdBtnCompleted.Name = "rdBtnCompleted";
            this.rdBtnCompleted.Size = new System.Drawing.Size(84, 19);
            this.rdBtnCompleted.TabIndex = 10;
            this.rdBtnCompleted.TabStop = true;
            this.rdBtnCompleted.Text = "Completed";
            this.rdBtnCompleted.UseVisualStyleBackColor = true;
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
            this.btnDisableFilters.Location = new System.Drawing.Point(350, 84);
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
            this.cmbBoxBuildings.Size = new System.Drawing.Size(266, 23);
            this.cmbBoxBuildings.TabIndex = 7;
            // 
            // btnApplyFilters
            // 
            this.btnApplyFilters.ForeColor = System.Drawing.Color.Black;
            this.btnApplyFilters.Location = new System.Drawing.Point(250, 84);
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
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Building:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCreateTask);
            this.groupBox2.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox2.Location = new System.Drawing.Point(516, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 117);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "More options";
            // 
            // AdminTasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AdminTasksForm";
            this.Text = "AdminTasksForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnCreateTask;
        private GroupBox groupBox1;
        private Button btnDisableFilters;
        private ComboBox cmbBoxBuildings;
        private Button btnApplyFilters;
        private Label label2;
        private GroupBox groupBox2;
        private RadioButton rdBtnCompleted;
        private RadioButton rdBtnForReview;
        private Label label1;
    }
}