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
            this.gbChangeDetails = new System.Windows.Forms.GroupBox();
            this.btnAccountChEmail = new System.Windows.Forms.Button();
            this.btnAccountChPhone = new System.Windows.Forms.Button();
            this.panelAccountInfo = new System.Windows.Forms.Panel();
            this.lbAccountNegVotes = new System.Windows.Forms.Label();
            this.lbAccountPosVotes = new System.Windows.Forms.Label();
            this.lbAccountPhone = new System.Windows.Forms.Label();
            this.lbAccountEmail = new System.Windows.Forms.Label();
            this.lbAccountName = new System.Windows.Forms.Label();
            this.lbAccountInfo6 = new System.Windows.Forms.Label();
            this.lbAccountInfo5 = new System.Windows.Forms.Label();
            this.lbAccountInfo4 = new System.Windows.Forms.Label();
            this.lbAccountInfo3 = new System.Windows.Forms.Label();
            this.lbAccountInfo2 = new System.Windows.Forms.Label();
            this.lbAccountInfo1 = new System.Windows.Forms.Label();
            this.btnAccountLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundStudentPanel)).BeginInit();
            this.navPages.SuspendLayout();
            this.pageAgreements.SuspendLayout();
            this.navAgreements.SuspendLayout();
            this.pageOpenAgreements.SuspendLayout();
            this.pageClosedAgreements.SuspendLayout();
            this.pageTasks.SuspendLayout();
            this.pageRules.SuspendLayout();
            this.pageAccount.SuspendLayout();
            this.gbChangeDetails.SuspendLayout();
            this.panelAccountInfo.SuspendLayout();
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
            this.flowOpenAgreements.BackColor = System.Drawing.Color.LightGray;
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
            this.flowClosedAgreements.BackColor = System.Drawing.Color.LightGray;
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
            this.pageAccount.Controls.Add(this.btnAccountLogout);
            this.pageAccount.Controls.Add(this.gbChangeDetails);
            this.pageAccount.Controls.Add(this.panelAccountInfo);
            this.pageAccount.Location = new System.Drawing.Point(4, 33);
            this.pageAccount.Name = "pageAccount";
            this.pageAccount.Padding = new System.Windows.Forms.Padding(3);
            this.pageAccount.Size = new System.Drawing.Size(961, 365);
            this.pageAccount.TabIndex = 3;
            this.pageAccount.Text = "ACCOUNT";
            // 
            // gbChangeDetails
            // 
            this.gbChangeDetails.BackColor = System.Drawing.Color.LightGray;
            this.gbChangeDetails.Controls.Add(this.btnAccountChEmail);
            this.gbChangeDetails.Controls.Add(this.btnAccountChPhone);
            this.gbChangeDetails.Location = new System.Drawing.Point(481, 77);
            this.gbChangeDetails.Name = "gbChangeDetails";
            this.gbChangeDetails.Size = new System.Drawing.Size(474, 98);
            this.gbChangeDetails.TabIndex = 3;
            this.gbChangeDetails.TabStop = false;
            this.gbChangeDetails.Text = "Change account details";
            // 
            // btnAccountChEmail
            // 
            this.btnAccountChEmail.Location = new System.Drawing.Point(6, 31);
            this.btnAccountChEmail.Name = "btnAccountChEmail";
            this.btnAccountChEmail.Size = new System.Drawing.Size(462, 23);
            this.btnAccountChEmail.TabIndex = 1;
            this.btnAccountChEmail.Text = "Change email address";
            this.btnAccountChEmail.UseVisualStyleBackColor = true;
            this.btnAccountChEmail.Click += new System.EventHandler(this.btnAccountChEmail_Click);
            // 
            // btnAccountChPhone
            // 
            this.btnAccountChPhone.Location = new System.Drawing.Point(6, 60);
            this.btnAccountChPhone.Name = "btnAccountChPhone";
            this.btnAccountChPhone.Size = new System.Drawing.Size(462, 23);
            this.btnAccountChPhone.TabIndex = 2;
            this.btnAccountChPhone.Text = "Change phone number";
            this.btnAccountChPhone.UseVisualStyleBackColor = true;
            this.btnAccountChPhone.Click += new System.EventHandler(this.btnAccountChPhone_Click);
            // 
            // panelAccountInfo
            // 
            this.panelAccountInfo.BackColor = System.Drawing.Color.LightGray;
            this.panelAccountInfo.Controls.Add(this.lbAccountNegVotes);
            this.panelAccountInfo.Controls.Add(this.lbAccountPosVotes);
            this.panelAccountInfo.Controls.Add(this.lbAccountPhone);
            this.panelAccountInfo.Controls.Add(this.lbAccountEmail);
            this.panelAccountInfo.Controls.Add(this.lbAccountName);
            this.panelAccountInfo.Controls.Add(this.lbAccountInfo6);
            this.panelAccountInfo.Controls.Add(this.lbAccountInfo5);
            this.panelAccountInfo.Controls.Add(this.lbAccountInfo4);
            this.panelAccountInfo.Controls.Add(this.lbAccountInfo3);
            this.panelAccountInfo.Controls.Add(this.lbAccountInfo2);
            this.panelAccountInfo.Controls.Add(this.lbAccountInfo1);
            this.panelAccountInfo.Location = new System.Drawing.Point(6, 6);
            this.panelAccountInfo.Name = "panelAccountInfo";
            this.panelAccountInfo.Size = new System.Drawing.Size(469, 353);
            this.panelAccountInfo.TabIndex = 0;
            // 
            // lbAccountNegVotes
            // 
            this.lbAccountNegVotes.AutoSize = true;
            this.lbAccountNegVotes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbAccountNegVotes.Location = new System.Drawing.Point(224, 210);
            this.lbAccountNegVotes.Name = "lbAccountNegVotes";
            this.lbAccountNegVotes.Size = new System.Drawing.Size(98, 17);
            this.lbAccountNegVotes.TabIndex = 10;
            this.lbAccountNegVotes.Text = "{value.negVotes}";
            // 
            // lbAccountPosVotes
            // 
            this.lbAccountPosVotes.AutoSize = true;
            this.lbAccountPosVotes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbAccountPosVotes.Location = new System.Drawing.Point(224, 181);
            this.lbAccountPosVotes.Name = "lbAccountPosVotes";
            this.lbAccountPosVotes.Size = new System.Drawing.Size(97, 17);
            this.lbAccountPosVotes.TabIndex = 9;
            this.lbAccountPosVotes.Text = "{value.posVotes}";
            // 
            // lbAccountPhone
            // 
            this.lbAccountPhone.AutoSize = true;
            this.lbAccountPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbAccountPhone.Location = new System.Drawing.Point(224, 152);
            this.lbAccountPhone.Name = "lbAccountPhone";
            this.lbAccountPhone.Size = new System.Drawing.Size(82, 17);
            this.lbAccountPhone.TabIndex = 8;
            this.lbAccountPhone.Text = "{value.phone}";
            // 
            // lbAccountEmail
            // 
            this.lbAccountEmail.AutoSize = true;
            this.lbAccountEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbAccountEmail.Location = new System.Drawing.Point(224, 123);
            this.lbAccountEmail.Name = "lbAccountEmail";
            this.lbAccountEmail.Size = new System.Drawing.Size(78, 17);
            this.lbAccountEmail.TabIndex = 7;
            this.lbAccountEmail.Text = "{value.email}";
            // 
            // lbAccountName
            // 
            this.lbAccountName.AutoSize = true;
            this.lbAccountName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbAccountName.Location = new System.Drawing.Point(224, 97);
            this.lbAccountName.Name = "lbAccountName";
            this.lbAccountName.Size = new System.Drawing.Size(79, 17);
            this.lbAccountName.TabIndex = 6;
            this.lbAccountName.Text = "{value.name}";
            // 
            // lbAccountInfo6
            // 
            this.lbAccountInfo6.AutoSize = true;
            this.lbAccountInfo6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbAccountInfo6.Location = new System.Drawing.Point(112, 210);
            this.lbAccountInfo6.Name = "lbAccountInfo6";
            this.lbAccountInfo6.Size = new System.Drawing.Size(106, 19);
            this.lbAccountInfo6.TabIndex = 5;
            this.lbAccountInfo6.Text = "Negative votes:";
            // 
            // lbAccountInfo5
            // 
            this.lbAccountInfo5.AutoSize = true;
            this.lbAccountInfo5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbAccountInfo5.Location = new System.Drawing.Point(120, 181);
            this.lbAccountInfo5.Name = "lbAccountInfo5";
            this.lbAccountInfo5.Size = new System.Drawing.Size(98, 19);
            this.lbAccountInfo5.TabIndex = 4;
            this.lbAccountInfo5.Text = "Positive votes:";
            // 
            // lbAccountInfo4
            // 
            this.lbAccountInfo4.AutoSize = true;
            this.lbAccountInfo4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbAccountInfo4.Location = new System.Drawing.Point(115, 152);
            this.lbAccountInfo4.Name = "lbAccountInfo4";
            this.lbAccountInfo4.Size = new System.Drawing.Size(103, 19);
            this.lbAccountInfo4.TabIndex = 3;
            this.lbAccountInfo4.Text = "Phone number:";
            // 
            // lbAccountInfo3
            // 
            this.lbAccountInfo3.AutoSize = true;
            this.lbAccountInfo3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbAccountInfo3.Location = new System.Drawing.Point(119, 123);
            this.lbAccountInfo3.Name = "lbAccountInfo3";
            this.lbAccountInfo3.Size = new System.Drawing.Size(99, 19);
            this.lbAccountInfo3.TabIndex = 2;
            this.lbAccountInfo3.Text = "Email address:";
            // 
            // lbAccountInfo2
            // 
            this.lbAccountInfo2.AutoSize = true;
            this.lbAccountInfo2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbAccountInfo2.Location = new System.Drawing.Point(144, 95);
            this.lbAccountInfo2.Name = "lbAccountInfo2";
            this.lbAccountInfo2.Size = new System.Drawing.Size(74, 19);
            this.lbAccountInfo2.TabIndex = 1;
            this.lbAccountInfo2.Text = "Full name:";
            // 
            // lbAccountInfo1
            // 
            this.lbAccountInfo1.AutoSize = true;
            this.lbAccountInfo1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbAccountInfo1.Location = new System.Drawing.Point(156, 36);
            this.lbAccountInfo1.Name = "lbAccountInfo1";
            this.lbAccountInfo1.Size = new System.Drawing.Size(128, 20);
            this.lbAccountInfo1.TabIndex = 0;
            this.lbAccountInfo1.Text = "User information:";
            // 
            // btnAccountLogout
            // 
            this.btnAccountLogout.Location = new System.Drawing.Point(688, 181);
            this.btnAccountLogout.Name = "btnAccountLogout";
            this.btnAccountLogout.Size = new System.Drawing.Size(75, 23);
            this.btnAccountLogout.TabIndex = 4;
            this.btnAccountLogout.Text = "Logout";
            this.btnAccountLogout.UseVisualStyleBackColor = true;
            this.btnAccountLogout.Click += new System.EventHandler(this.btnAccountLogout_Click);
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
            this.pageAccount.ResumeLayout(false);
            this.gbChangeDetails.ResumeLayout(false);
            this.panelAccountInfo.ResumeLayout(false);
            this.panelAccountInfo.PerformLayout();
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
        private Panel panelAccountInfo;
        private Label lbAccountInfo2;
        private Label lbAccountInfo1;
        private Label lbAccountNegVotes;
        private Label lbAccountPosVotes;
        private Label lbAccountPhone;
        private Label lbAccountEmail;
        private Label lbAccountName;
        private Label lbAccountInfo6;
        private Label lbAccountInfo5;
        private Label lbAccountInfo4;
        private Label lbAccountInfo3;
        private GroupBox gbChangeDetails;
        private Button btnAccountChEmail;
        private Button btnAccountChPhone;
        private Button btnAccountLogout;
    }
}