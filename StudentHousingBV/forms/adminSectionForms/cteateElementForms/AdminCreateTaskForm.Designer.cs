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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.rdBtnPaymentNo = new System.Windows.Forms.RadioButton();
            this.rdBtnPaymentYes = new System.Windows.Forms.RadioButton();
            this.cmbBoxBuildings = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Does it include payment:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Create Task";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Building:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(257, 263);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(98, 27);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(224, 72);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(300, 23);
            this.txtBoxTitle.TabIndex = 7;
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Location = new System.Drawing.Point(224, 116);
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(300, 23);
            this.txtBoxDescription.TabIndex = 8;
            // 
            // rdBtnPaymentNo
            // 
            this.rdBtnPaymentNo.AutoSize = true;
            this.rdBtnPaymentNo.Location = new System.Drawing.Point(293, 168);
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
            this.rdBtnPaymentYes.Location = new System.Drawing.Point(340, 168);
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
            this.cmbBoxBuildings.Location = new System.Drawing.Point(224, 205);
            this.cmbBoxBuildings.Name = "cmbBoxBuildings";
            this.cmbBoxBuildings.Size = new System.Drawing.Size(300, 23);
            this.cmbBoxBuildings.TabIndex = 11;
            // 
            // AdminCreateTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 369);
            this.Controls.Add(this.cmbBoxBuildings);
            this.Controls.Add(this.rdBtnPaymentYes);
            this.Controls.Add(this.rdBtnPaymentNo);
            this.Controls.Add(this.txtBoxDescription);
            this.Controls.Add(this.txtBoxTitle);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminCreateTaskForm";
            this.Text = "v";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnCreate;
        private TextBox txtBoxTitle;
        private TextBox txtBoxDescription;
        private RadioButton rdBtnPaymentNo;
        private RadioButton rdBtnPaymentYes;
        private ComboBox cmbBoxBuildings;
    }
}