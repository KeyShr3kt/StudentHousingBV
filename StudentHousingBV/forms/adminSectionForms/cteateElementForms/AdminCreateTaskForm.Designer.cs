namespace StudentHousingBV.forms.adminSectionForms
{
    partial class AdminCreateTaskForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.rdBtnPaymentNo = new System.Windows.Forms.RadioButton();
            this.rdBtnPaymentYes = new System.Windows.Forms.RadioButton();
            this.cmbBoxBuildings = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(19, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Create Task";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Building:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(268, 406);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(98, 27);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxTitle.Location = new System.Drawing.Point(79, 36);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(268, 23);
            this.txtBoxTitle.TabIndex = 7;
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxDescription.Location = new System.Drawing.Point(79, 71);
            this.txtBoxDescription.Multiline = true;
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(268, 151);
            this.txtBoxDescription.TabIndex = 8;
            // 
            // rdBtnPaymentNo
            // 
            this.rdBtnPaymentNo.AutoSize = true;
            this.rdBtnPaymentNo.ForeColor = System.Drawing.Color.Black;
            this.rdBtnPaymentNo.Location = new System.Drawing.Point(65, 20);
            this.rdBtnPaymentNo.Name = "rdBtnPaymentNo";
            this.rdBtnPaymentNo.Size = new System.Drawing.Size(41, 19);
            this.rdBtnPaymentNo.TabIndex = 9;
            this.rdBtnPaymentNo.TabStop = true;
            this.rdBtnPaymentNo.Text = "No";
            this.rdBtnPaymentNo.UseVisualStyleBackColor = true;
            // 
            // rdBtnPaymentYes
            // 
            this.rdBtnPaymentYes.AutoSize = true;
            this.rdBtnPaymentYes.ForeColor = System.Drawing.Color.Black;
            this.rdBtnPaymentYes.Location = new System.Drawing.Point(17, 20);
            this.rdBtnPaymentYes.Name = "rdBtnPaymentYes";
            this.rdBtnPaymentYes.Size = new System.Drawing.Size(42, 19);
            this.rdBtnPaymentYes.TabIndex = 10;
            this.rdBtnPaymentYes.TabStop = true;
            this.rdBtnPaymentYes.Text = "Yes";
            this.rdBtnPaymentYes.UseVisualStyleBackColor = true;
            // 
            // cmbBoxBuildings
            // 
            this.cmbBoxBuildings.FormattingEnabled = true;
            this.cmbBoxBuildings.Location = new System.Drawing.Point(80, 22);
            this.cmbBoxBuildings.Name = "cmbBoxBuildings";
            this.cmbBoxBuildings.Size = new System.Drawing.Size(268, 23);
            this.cmbBoxBuildings.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBoxTitle);
            this.groupBox1.Controls.Add(this.txtBoxDescription);
            this.groupBox1.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Location = new System.Drawing.Point(13, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 229);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbBoxBuildings);
            this.groupBox2.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox2.Location = new System.Drawing.Point(13, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 58);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "House Details";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdBtnPaymentNo);
            this.groupBox3.Controls.Add(this.rdBtnPaymentYes);
            this.groupBox3.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox3.Location = new System.Drawing.Point(13, 355);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 45);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payment";
            // 
            // AdminCreateTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 445);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label4);
            this.Name = "AdminCreateTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Button btnCreate;
        private TextBox txtBoxTitle;
        private TextBox txtBoxDescription;
        private RadioButton rdBtnPaymentNo;
        private RadioButton rdBtnPaymentYes;
        private ComboBox cmbBoxBuildings;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}