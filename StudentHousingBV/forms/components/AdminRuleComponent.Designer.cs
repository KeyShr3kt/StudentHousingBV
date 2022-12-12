namespace StudentHousingBV.forms.components
{
    partial class AdminRuleComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblRuleDescription = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblForBuilding = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblUpdatedAt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(42, 28);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lblRuleDescription
            // 
            this.lblRuleDescription.Location = new System.Drawing.Point(3, 3);
            this.lblRuleDescription.Name = "lblRuleDescription";
            this.lblRuleDescription.Size = new System.Drawing.Size(306, 49);
            this.lblRuleDescription.TabIndex = 1;
            this.lblRuleDescription.Text = "description";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblRuleDescription);
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 49);
            this.panel1.TabIndex = 2;
            // 
            // lblForBuilding
            // 
            this.lblForBuilding.AutoSize = true;
            this.lblForBuilding.Location = new System.Drawing.Point(2, 3);
            this.lblForBuilding.Name = "lblForBuilding";
            this.lblForBuilding.Size = new System.Drawing.Size(51, 15);
            this.lblForBuilding.TabIndex = 3;
            this.lblForBuilding.Text = "Building";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Location = new System.Drawing.Point(3, 22);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(64, 15);
            this.lblCreatedBy.TabIndex = 4;
            this.lblCreatedBy.Text = "Created by";
            // 
            // lblUpdatedAt
            // 
            this.lblUpdatedAt.AutoSize = true;
            this.lblUpdatedAt.Location = new System.Drawing.Point(2, 37);
            this.lblUpdatedAt.Name = "lblUpdatedAt";
            this.lblUpdatedAt.Size = new System.Drawing.Size(64, 15);
            this.lblUpdatedAt.TabIndex = 5;
            this.lblUpdatedAt.Text = "UpdatedAt";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCreatedBy);
            this.panel2.Controls.Add(this.lblUpdatedAt);
            this.panel2.Controls.Add(this.lblForBuilding);
            this.panel2.Location = new System.Drawing.Point(339, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 58);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(630, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 75);
            this.panel3.TabIndex = 7;
            // 
            // AdminRuleComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminRuleComponent";
            this.Size = new System.Drawing.Size(790, 75);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnEdit;
        private Label lblRuleDescription;
        private Panel panel1;
        private Label lblForBuilding;
        private Label lblCreatedBy;
        private Label lblUpdatedAt;
        private Panel panel2;
        private Panel panel3;
    }
}
