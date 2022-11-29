namespace StudentHousingBV.forms
{
    partial class AgreementPanel
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
            this.backgroundPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundPicture
            // 
            this.backgroundPicture.Image = global::StudentHousingBV.Properties.Resources.TUe_by_night1;
            this.backgroundPicture.Location = new System.Drawing.Point(12, 12);
            this.backgroundPicture.Name = "backgroundPicture";
            this.backgroundPicture.Size = new System.Drawing.Size(969, 155);
            this.backgroundPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundPicture.TabIndex = 1;
            this.backgroundPicture.TabStop = false;
            // 
            // AgreementPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 587);
            this.Controls.Add(this.backgroundPicture);
            this.Name = "AgreementPanel";
            this.Text = "Student Housing BV - Agreement View";
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox backgroundPicture;
    }
}