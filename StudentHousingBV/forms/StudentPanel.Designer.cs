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
            this.navAgreements = new System.Windows.Forms.TabControl();
            this.pageClosedAgreements = new System.Windows.Forms.TabPage();
            this.btnReportClosedAgreement = new StudentHousingBV.forms.RoundButton();
            this.selectClosedAgreement = new System.Windows.Forms.ComboBox();
            this.btnClosedAgreement = new System.Windows.Forms.Button();
            this.listClosedAgreements = new System.Windows.Forms.ListBox();
            this.pageOpenAgreements = new System.Windows.Forms.TabPage();
            this.btnReportOpenAgreement = new StudentHousingBV.forms.RoundButton();
            this.selectOpenAgreement = new System.Windows.Forms.ComboBox();
            this.listOpenAgreements = new System.Windows.Forms.ListBox();
            this.btnOpenAgreement = new System.Windows.Forms.Button();
            this.pageTasks = new System.Windows.Forms.TabPage();
            this.fpPageTasks = new System.Windows.Forms.FlowLayoutPanel();
            this.pageRules = new System.Windows.Forms.TabPage();
            this.flowRules = new System.Windows.Forms.FlowLayoutPanel();
            this.pageAccount = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundStudentPanel)).BeginInit();
            this.navPages.SuspendLayout();
            this.pageAgreements.SuspendLayout();
            this.navAgreements.SuspendLayout();
            this.pageClosedAgreements.SuspendLayout();
            this.pageOpenAgreements.SuspendLayout();
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
            this.pageAgreements.Controls.Add(this.navAgreements);
            this.pageAgreements.Location = new System.Drawing.Point(4, 33);
            this.pageAgreements.Name = "pageAgreements";
            this.pageAgreements.Padding = new System.Windows.Forms.Padding(3);
            this.pageAgreements.Size = new System.Drawing.Size(961, 365);
            this.pageAgreements.TabIndex = 0;
            this.pageAgreements.Text = "AGREEMENTS";
            // 
            // navAgreements
            // 
            this.navAgreements.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.navAgreements.Controls.Add(this.pageClosedAgreements);
            this.navAgreements.Controls.Add(this.pageOpenAgreements);
            this.navAgreements.Location = new System.Drawing.Point(6, 6);
            this.navAgreements.Name = "navAgreements";
            this.navAgreements.Padding = new System.Drawing.Point(185, 3);
            this.navAgreements.SelectedIndex = 0;
            this.navAgreements.Size = new System.Drawing.Size(949, 353);
            this.navAgreements.TabIndex = 0;
            // 
            // pageClosedAgreements
            // 
            this.pageClosedAgreements.BackColor = System.Drawing.Color.RosyBrown;
            this.pageClosedAgreements.Controls.Add(this.btnReportClosedAgreement);
            this.pageClosedAgreements.Controls.Add(this.selectClosedAgreement);
            this.pageClosedAgreements.Controls.Add(this.btnClosedAgreement);
            this.pageClosedAgreements.Controls.Add(this.listClosedAgreements);
            this.pageClosedAgreements.Location = new System.Drawing.Point(4, 27);
            this.pageClosedAgreements.Name = "pageClosedAgreements";
            this.pageClosedAgreements.Padding = new System.Windows.Forms.Padding(3);
            this.pageClosedAgreements.Size = new System.Drawing.Size(941, 322);
            this.pageClosedAgreements.TabIndex = 0;
            this.pageClosedAgreements.Text = "Closed Agreements";
            // 
            // btnReportClosedAgreement
            // 
            this.btnReportClosedAgreement.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReportClosedAgreement.ForeColor = System.Drawing.Color.Red;
            this.btnReportClosedAgreement.Location = new System.Drawing.Point(6, 255);
            this.btnReportClosedAgreement.Name = "btnReportClosedAgreement";
            this.btnReportClosedAgreement.Size = new System.Drawing.Size(75, 60);
            this.btnReportClosedAgreement.TabIndex = 8;
            this.btnReportClosedAgreement.Text = "!";
            this.btnReportClosedAgreement.UseVisualStyleBackColor = true;
            // 
            // selectClosedAgreement
            // 
            this.selectClosedAgreement.FormattingEnabled = true;
            this.selectClosedAgreement.Location = new System.Drawing.Point(87, 256);
            this.selectClosedAgreement.Name = "selectClosedAgreement";
            this.selectClosedAgreement.Size = new System.Drawing.Size(848, 23);
            this.selectClosedAgreement.TabIndex = 10;
            // 
            // btnClosedAgreement
            // 
            this.btnClosedAgreement.BackColor = System.Drawing.Color.Brown;
            this.btnClosedAgreement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClosedAgreement.ForeColor = System.Drawing.Color.White;
            this.btnClosedAgreement.Location = new System.Drawing.Point(87, 285);
            this.btnClosedAgreement.Name = "btnClosedAgreement";
            this.btnClosedAgreement.Size = new System.Drawing.Size(848, 30);
            this.btnClosedAgreement.TabIndex = 9;
            this.btnClosedAgreement.Text = "Expand Agreement";
            this.btnClosedAgreement.UseVisualStyleBackColor = false;
            // 
            // listClosedAgreements
            // 
            this.listClosedAgreements.BackColor = System.Drawing.Color.White;
            this.listClosedAgreements.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listClosedAgreements.FormattingEnabled = true;
            this.listClosedAgreements.ItemHeight = 21;
            this.listClosedAgreements.Location = new System.Drawing.Point(6, 6);
            this.listClosedAgreements.Name = "listClosedAgreements";
            this.listClosedAgreements.Size = new System.Drawing.Size(929, 235);
            this.listClosedAgreements.TabIndex = 0;
            // 
            // pageOpenAgreements
            // 
            this.pageOpenAgreements.BackColor = System.Drawing.Color.RosyBrown;
            this.pageOpenAgreements.Controls.Add(this.btnReportOpenAgreement);
            this.pageOpenAgreements.Controls.Add(this.selectOpenAgreement);
            this.pageOpenAgreements.Controls.Add(this.listOpenAgreements);
            this.pageOpenAgreements.Controls.Add(this.btnOpenAgreement);
            this.pageOpenAgreements.Location = new System.Drawing.Point(4, 27);
            this.pageOpenAgreements.Name = "pageOpenAgreements";
            this.pageOpenAgreements.Padding = new System.Windows.Forms.Padding(3);
            this.pageOpenAgreements.Size = new System.Drawing.Size(941, 322);
            this.pageOpenAgreements.TabIndex = 1;
            this.pageOpenAgreements.Text = "Open Agreements";
            // 
            // btnReportOpenAgreement
            // 
            this.btnReportOpenAgreement.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReportOpenAgreement.ForeColor = System.Drawing.Color.Red;
            this.btnReportOpenAgreement.Location = new System.Drawing.Point(6, 256);
            this.btnReportOpenAgreement.Name = "btnReportOpenAgreement";
            this.btnReportOpenAgreement.Size = new System.Drawing.Size(75, 60);
            this.btnReportOpenAgreement.TabIndex = 2;
            this.btnReportOpenAgreement.Text = "!";
            this.btnReportOpenAgreement.UseVisualStyleBackColor = true;
            // 
            // selectOpenAgreement
            // 
            this.selectOpenAgreement.FormattingEnabled = true;
            this.selectOpenAgreement.Location = new System.Drawing.Point(87, 257);
            this.selectOpenAgreement.Name = "selectOpenAgreement";
            this.selectOpenAgreement.Size = new System.Drawing.Size(848, 23);
            this.selectOpenAgreement.TabIndex = 7;
            // 
            // listOpenAgreements
            // 
            this.listOpenAgreements.BackColor = System.Drawing.Color.White;
            this.listOpenAgreements.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listOpenAgreements.FormattingEnabled = true;
            this.listOpenAgreements.ItemHeight = 21;
            this.listOpenAgreements.Location = new System.Drawing.Point(6, 6);
            this.listOpenAgreements.Name = "listOpenAgreements";
            this.listOpenAgreements.Size = new System.Drawing.Size(929, 235);
            this.listOpenAgreements.TabIndex = 6;
            // 
            // btnOpenAgreement
            // 
            this.btnOpenAgreement.BackColor = System.Drawing.Color.Brown;
            this.btnOpenAgreement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOpenAgreement.ForeColor = System.Drawing.Color.White;
            this.btnOpenAgreement.Location = new System.Drawing.Point(87, 286);
            this.btnOpenAgreement.Name = "btnOpenAgreement";
            this.btnOpenAgreement.Size = new System.Drawing.Size(848, 30);
            this.btnOpenAgreement.TabIndex = 3;
            this.btnOpenAgreement.Text = "Expand Agreement";
            this.btnOpenAgreement.UseVisualStyleBackColor = false;
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
            this.Text = "Student Housing BV - Student Panel";
            ((System.ComponentModel.ISupportInitialize)(this.backgroundStudentPanel)).EndInit();
            this.navPages.ResumeLayout(false);
            this.pageAgreements.ResumeLayout(false);
            this.navAgreements.ResumeLayout(false);
            this.pageClosedAgreements.ResumeLayout(false);
            this.pageOpenAgreements.ResumeLayout(false);
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
        private TabPage pageClosedAgreements;
        private TabPage pageOpenAgreements;
        private ListBox listClosedAgreements;
        private Button btnOpenAgreement;
        private ComboBox selectOpenAgreement;
        private ListBox listOpenAgreements;
        private RoundButton btnReportClosedAgreement;
        private ComboBox selectClosedAgreement;
        private Button btnClosedAgreement;
        private RoundButton btnReportOpenAgreement;
        private FlowLayoutPanel fpPageTasks;
        private FlowLayoutPanel flowRules;
    }
}