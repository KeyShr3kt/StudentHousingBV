namespace StudentHousingBV.forms
{
    partial class AdminForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.sidebarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.usersPanel = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.rulesPanel = new System.Windows.Forms.Panel();
            this.btnCreateRules = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            this.tasksPanel = new System.Windows.Forms.Panel();
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.btnTasks = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.tasksTimer = new System.Windows.Forms.Timer(this.components);
            this.usersTimer = new System.Windows.Forms.Timer(this.components);
            this.rulesTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebarPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel10.SuspendLayout();
            this.usersPanel.SuspendLayout();
            this.rulesPanel.SuspendLayout();
            this.tasksPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.RosyBrown;
            this.sidebarPanel.Controls.Add(this.panel1);
            this.sidebarPanel.Controls.Add(this.panel10);
            this.sidebarPanel.Controls.Add(this.usersPanel);
            this.sidebarPanel.Controls.Add(this.rulesPanel);
            this.sidebarPanel.Controls.Add(this.tasksPanel);
            this.sidebarPanel.Controls.Add(this.panel2);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.MaximumSize = new System.Drawing.Size(320, 942);
            this.sidebarPanel.MinimumSize = new System.Drawing.Size(122, 942);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(320, 942);
            this.sidebarPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 106);
            this.panel1.TabIndex = 0;
            // 
            // menuButton
            // 
            this.menuButton.ErrorImage = global::StudentHousingBV.Properties.Resources.menuButton;
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.Location = new System.Drawing.Point(-3, 26);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(107, 64);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.RosyBrown;
            this.panel10.Controls.Add(this.button9);
            this.panel10.Location = new System.Drawing.Point(3, 115);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(317, 75);
            this.panel10.TabIndex = 2;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.RosyBrown;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(-3, -16);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(332, 107);
            this.button9.TabIndex = 2;
            this.button9.Text = "Home";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // usersPanel
            // 
            this.usersPanel.BackColor = System.Drawing.Color.RosyBrown;
            this.usersPanel.Controls.Add(this.button13);
            this.usersPanel.Controls.Add(this.btnUsers);
            this.usersPanel.Location = new System.Drawing.Point(3, 196);
            this.usersPanel.MaximumSize = new System.Drawing.Size(318, 113);
            this.usersPanel.MinimumSize = new System.Drawing.Size(318, 58);
            this.usersPanel.Name = "usersPanel";
            this.usersPanel.Size = new System.Drawing.Size(318, 58);
            this.usersPanel.TabIndex = 6;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.RosyBrown;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(-10, 60);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(329, 53);
            this.button13.TabIndex = 2;
            this.button13.Text = "Create";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.RosyBrown;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(-10, -9);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(329, 74);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = " Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // rulesPanel
            // 
            this.rulesPanel.BackColor = System.Drawing.Color.RosyBrown;
            this.rulesPanel.Controls.Add(this.btnCreateRules);
            this.rulesPanel.Controls.Add(this.btnRules);
            this.rulesPanel.Location = new System.Drawing.Point(3, 260);
            this.rulesPanel.MaximumSize = new System.Drawing.Size(318, 113);
            this.rulesPanel.MinimumSize = new System.Drawing.Size(318, 58);
            this.rulesPanel.Name = "rulesPanel";
            this.rulesPanel.Size = new System.Drawing.Size(318, 58);
            this.rulesPanel.TabIndex = 13;
            // 
            // btnCreateRules
            // 
            this.btnCreateRules.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCreateRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateRules.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateRules.ForeColor = System.Drawing.Color.White;
            this.btnCreateRules.Location = new System.Drawing.Point(-10, 60);
            this.btnCreateRules.Name = "btnCreateRules";
            this.btnCreateRules.Size = new System.Drawing.Size(329, 53);
            this.btnCreateRules.TabIndex = 2;
            this.btnCreateRules.Text = "Create";
            this.btnCreateRules.UseVisualStyleBackColor = false;
            // 
            // btnRules
            // 
            this.btnRules.BackColor = System.Drawing.Color.RosyBrown;
            this.btnRules.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRules.ForeColor = System.Drawing.Color.White;
            this.btnRules.Location = new System.Drawing.Point(-10, -9);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(329, 74);
            this.btnRules.TabIndex = 2;
            this.btnRules.Text = " Rules";
            this.btnRules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRules.UseVisualStyleBackColor = false;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // tasksPanel
            // 
            this.tasksPanel.BackColor = System.Drawing.Color.RosyBrown;
            this.tasksPanel.Controls.Add(this.btnCreateTask);
            this.tasksPanel.Controls.Add(this.btnTasks);
            this.tasksPanel.Location = new System.Drawing.Point(3, 324);
            this.tasksPanel.MaximumSize = new System.Drawing.Size(318, 113);
            this.tasksPanel.MinimumSize = new System.Drawing.Size(318, 58);
            this.tasksPanel.Name = "tasksPanel";
            this.tasksPanel.Size = new System.Drawing.Size(318, 58);
            this.tasksPanel.TabIndex = 12;
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCreateTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTask.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateTask.ForeColor = System.Drawing.Color.White;
            this.btnCreateTask.Location = new System.Drawing.Point(-10, 60);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(329, 53);
            this.btnCreateTask.TabIndex = 2;
            this.btnCreateTask.Text = "Create";
            this.btnCreateTask.UseVisualStyleBackColor = false;
            // 
            // btnTasks
            // 
            this.btnTasks.BackColor = System.Drawing.Color.RosyBrown;
            this.btnTasks.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTasks.ForeColor = System.Drawing.Color.White;
            this.btnTasks.Location = new System.Drawing.Point(-10, -9);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(329, 74);
            this.btnTasks.TabIndex = 2;
            this.btnTasks.Text = " Tasks";
            this.btnTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTasks.UseVisualStyleBackColor = false;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.panel2.Controls.Add(this.btnReports);
            this.panel2.Location = new System.Drawing.Point(3, 388);
            this.panel2.MaximumSize = new System.Drawing.Size(318, 113);
            this.panel2.MinimumSize = new System.Drawing.Size(318, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 58);
            this.panel2.TabIndex = 13;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.RosyBrown;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(-10, -9);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(329, 74);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = " Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 77);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 7;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick_1);
            // 
            // tasksTimer
            // 
            this.tasksTimer.Interval = 10;
            this.tasksTimer.Tick += new System.EventHandler(this.tasksTimer_Tick);
            // 
            // usersTimer
            // 
            this.usersTimer.Interval = 10;
            this.usersTimer.Tick += new System.EventHandler(this.usersTimer_Tick);
            // 
            // rulesTimer
            // 
            this.rulesTimer.Interval = 7;
            this.rulesTimer.Tick += new System.EventHandler(this.rulesTimer_Tick);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 942);
            this.Controls.Add(this.sidebarPanel);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.sidebarPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel10.ResumeLayout(false);
            this.usersPanel.ResumeLayout(false);
            this.rulesPanel.ResumeLayout(false);
            this.tasksPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel sidebarPanel;
        private Panel panel1;
        private Button button1;
        private Panel panel10;
        private Button button9;
        private System.Windows.Forms.Timer sidebarTimer;
        private PictureBox menuButton;
        private System.Windows.Forms.Timer tasksTimer;
        private System.Windows.Forms.Timer usersTimer;
        private Panel usersPanel;
        private Button btnUsers;
        private Button button13;
        private Panel rulesPanel;
        private Button btnCreateRules;
        private Button btnRules;
        private Panel tasksPanel;
        private Button btnCreateTask;
        private Button btnTasks;
        private Panel panel2;
        private Button btnReports;
        private System.Windows.Forms.Timer rulesTimer;
    }
}