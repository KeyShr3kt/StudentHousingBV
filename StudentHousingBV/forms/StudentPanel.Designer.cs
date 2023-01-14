namespace StudentHousingBV.forms
{
    partial class StudentPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundStudentPanel = new System.Windows.Forms.PictureBox();
            this.navPages = new System.Windows.Forms.TabControl();
            this.pageAgreements = new System.Windows.Forms.TabPage();
            this.btnCreateAgreement = new System.Windows.Forms.Button();
            this.navAgreements = new System.Windows.Forms.TabControl();
            this.pageOpenAgreements = new System.Windows.Forms.TabPage();
            this.flowOpenAgreements = new System.Windows.Forms.FlowLayoutPanel();
            this.pageClosedAgreements = new System.Windows.Forms.TabPage();
            this.flowClosedAgreements = new System.Windows.Forms.FlowLayoutPanel();
            this.pageTasks = new System.Windows.Forms.TabPage();
            this.fpPageTasks = new System.Windows.Forms.FlowLayoutPanel();
            this.pageRules = new System.Windows.Forms.TabPage();
            this.flowRules = new System.Windows.Forms.FlowLayoutPanel();
            this.pageAccount = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundStudentPanel)).BeginInit();
            this.navPages.SuspendLayout();
            this.pageAgreements.SuspendLayout();
            this.navAgreements.SuspendLayout();
            this.pageOpenAgreements.SuspendLayout();
            this.pageClosedAgreements.SuspendLayout();
            this.pageTasks.SuspendLayout();
            this.pageRules.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundStudentPanel
            // 
            this.backgroundStudentPanel.Image = global::StudentHousingBV.Properties.Resources.TUe_by_night1;
            this.backgroundStudentPanel.Location = new System.Drawing.Point(12, 12);
            this.backgroundStudentPanel.Name = "backgroundStudentPanel";
            this.backgroundStudentPanel.Size = new System.Drawing.Size(969, 155);
            this.backgroundStudentPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundStudentPanel.TabIndex = 0;
            this.backgroundStudentPanel.TabStop = false;
            // 
            // navPages
            // 
            this.navPages.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.navPages.Controls.Add(this.pageAgreements);
            this.navPages.Controls.Add(this.pageTasks);
            this.navPages.Controls.Add(this.pageRules);
            this.navPages.Controls.Add(this.pageAccount);
            this.navPages.Location = new System.Drawing.Point(12, 173);
            this.navPages.Name = "navPages";
            this.navPages.Padding = new System.Drawing.Point(94, 6);
            this.navPages.SelectedIndex = 0;
            this.navPages.Size = new System.Drawing.Size(969, 402);
            this.navPages.TabIndex = 1;
            // 
            // pageAgreements
            // 
            this.pageAgreements.BackColor = System.Drawing.Color.RosyBrown;
            this.pageAgreements.Controls.Add(this.btnCreateAgreement);
            this.pageAgreements.Controls.Add(this.navAgreements);
            this.pageAgreements.Location = new System.Drawing.Point(4, 33);
            this.pageAgreements.Name = "pageAgreements";
            this.pageAgreements.Padding = new System.Windows.Forms.Padding(3);
            this.pageAgreements.Size = new System.Drawing.Size(961, 365);
            this.pageAgreements.TabIndex = 0;
            this.pageAgreements.Text = "AGREEMENTS";
            // 
            // btnCreateAgreement
            // 
            this.btnCreateAgreement.Location = new System.Drawing.Point(10, 336);
            this.btnCreateAgreement.Name = "btnCreateAgreement";
            this.btnCreateAgreement.Size = new System.Drawing.Size(941, 23);
            this.btnCreateAgreement.TabIndex = 1;
            this.btnCreateAgreement.Text = "Create Agreement";
            this.btnCreateAgreement.UseVisualStyleBackColor = true;
            this.btnCreateAgreement.Click += new System.EventHandler(this.btnCreateAgreement_Click);
            // 
            // navAgreements
            // 
            this.navAgreements.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.navAgreements.Controls.Add(this.pageOpenAgreements);
            this.navAgreements.Controls.Add(this.pageClosedAgreements);
            this.navAgreements.Location = new System.Drawing.Point(6, 6);
            this.navAgreements.Name = "navAgreements";
            this.navAgreements.Padding = new System.Drawing.Point(185, 3);
            this.navAgreements.SelectedIndex = 0;
            this.navAgreements.Size = new System.Drawing.Size(949, 324);
            this.navAgreements.TabIndex = 0;
            // 
            // pageOpenAgreements
            // 
            this.pageOpenAgreements.BackColor = System.Drawing.Color.RosyBrown;
            this.pageOpenAgreements.Controls.Add(this.flowOpenAgreements);
            this.pageOpenAgreements.Location = new System.Drawing.Point(4, 27);
            this.pageOpenAgreements.Name = "pageOpenAgreements";
            this.pageOpenAgreements.Padding = new System.Windows.Forms.Padding(3);
            this.pageOpenAgreements.Size = new System.Drawing.Size(941, 293);
            this.pageOpenAgreements.TabIndex = 0;
            this.pageOpenAgreements.Text = "Open Agreements";
            // 
            // flowOpenAgreements
            // 
            this.flowOpenAgreements.AutoScroll = true;
            this.flowOpenAgreements.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowOpenAgreements.Location = new System.Drawing.Point(5, 5);
            this.flowOpenAgreements.Name = "flowOpenAgreements";
            this.flowOpenAgreements.Size = new System.Drawing.Size(931, 282);
            this.flowOpenAgreements.TabIndex = 0;
            this.flowOpenAgreements.WrapContents = false;
            // 
            // pageClosedAgreements
            // 
            this.pageClosedAgreements.BackColor = System.Drawing.Color.RosyBrown;
            this.pageClosedAgreements.Controls.Add(this.flowClosedAgreements);
            this.pageClosedAgreements.Location = new System.Drawing.Point(4, 27);
            this.pageClosedAgreements.Name = "pageClosedAgreements";
            this.pageClosedAgreements.Padding = new System.Windows.Forms.Padding(3);
            this.pageClosedAgreements.Size = new System.Drawing.Size(941, 293);
            this.pageClosedAgreements.TabIndex = 1;
            this.pageClosedAgreements.Text = "Closed Agreements";
            // 
            // flowClosedAgreements
            // 
            this.flowClosedAgreements.AutoScroll = true;
            this.flowClosedAgreements.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowClosedAgreements.Location = new System.Drawing.Point(5, 5);
            this.flowClosedAgreements.Name = "flowClosedAgreements";
            this.flowClosedAgreements.Size = new System.Drawing.Size(931, 282);
            this.flowClosedAgreements.TabIndex = 0;
            this.flowClosedAgreements.WrapContents = false;
            // 
            // pageTasks
            // 
            this.pageTasks.BackColor = System.Drawing.Color.RosyBrown;
            this.pageTasks.Controls.Add(this.fpPageTasks);
            this.pageTasks.Location = new System.Drawing.Point(4, 33);
            this.pageTasks.Name = "pageTasks";
            this.pageTasks.Padding = new System.Windows.Forms.Padding(3);
            this.pageTasks.Size = new System.Drawing.Size(961, 365);
            this.pageTasks.TabIndex = 1;
            this.pageTasks.Text = "TASKS";
            // 
            // fpPageTasks
            // 
            this.fpPageTasks.AutoScroll = true;
            this.fpPageTasks.BackColor = System.Drawing.Color.LightGray;
            this.fpPageTasks.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpPageTasks.Location = new System.Drawing.Point(6, 6);
            this.fpPageTasks.Name = "fpPageTasks";
            this.fpPageTasks.Size = new System.Drawing.Size(949, 353);
            this.fpPageTasks.TabIndex = 10;
            this.fpPageTasks.WrapContents = false;
            // 
            // pageRules
            // 
            this.pageRules.BackColor = System.Drawing.Color.RosyBrown;
            this.pageRules.Controls.Add(this.flowRules);
            this.pageRules.Location = new System.Drawing.Point(4, 33);
            this.pageRules.Name = "pageRules";
            this.pageRules.Padding = new System.Windows.Forms.Padding(3);
            this.pageRules.Size = new System.Drawing.Size(961, 365);
            this.pageRules.TabIndex = 2;
            this.pageRules.Text = "RULES";
            // 
            // flowRules
            // 
            this.flowRules.AutoScroll = true;
            this.flowRules.BackColor = System.Drawing.Color.LightGray;
            this.flowRules.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowRules.Location = new System.Drawing.Point(6, 6);
            this.flowRules.Name = "flowRules";
            this.flowRules.Size = new System.Drawing.Size(949, 353);
            this.flowRules.TabIndex = 11;
            this.flowRules.WrapContents = false;
            // 
            // pageAccount
            // 
            this.pageAccount.BackColor = System.Drawing.Color.RosyBrown;
            this.pageAccount.Location = new System.Drawing.Point(4, 33);
            this.pageAccount.Name = "pageAccount";
            this.pageAccount.Padding = new System.Windows.Forms.Padding(3);
            this.pageAccount.Size = new System.Drawing.Size(961, 365);
            this.pageAccount.TabIndex = 3;
            this.pageAccount.Text = "ACCOUNT";
            // 
            // StudentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 587);
            this.Controls.Add(this.navPages);
            this.Controls.Add(this.backgroundStudentPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "StudentPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Housing BV - Student Panel";
            ((System.ComponentModel.ISupportInitialize)(this.backgroundStudentPanel)).EndInit();
            this.navPages.ResumeLayout(false);
            this.pageAgreements.ResumeLayout(false);
            this.navAgreements.ResumeLayout(false);
            this.pageOpenAgreements.ResumeLayout(false);
            this.pageClosedAgreements.ResumeLayout(false);
            this.pageTasks.ResumeLayout(false);
            this.pageRules.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox backgroundStudentPanel;
        private TabControl navPages;
        private TabPage pageAgreements;
        private TabPage pageTasks;
        private TabPage pageRules;
        private TabPage pageAccount;
        private TabControl navAgreements;
        private TabPage pageOpenAgreements;
        private TabPage pageClosedAgreements;
        private FlowLayoutPanel fpPageTasks;
        private FlowLayoutPanel flowRules;
        private FlowLayoutPanel flowOpenAgreements;
        private FlowLayoutPanel flowClosedAgreements;
        private Button btnCreateAgreement;
    }
}