namespace LicensingControls
{
    partial class DeleteSoftwareControl
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
            this.cbSoftwareList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbSoftwareList
            // 
            this.cbSoftwareList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSoftwareList.FormattingEnabled = true;
            this.cbSoftwareList.Location = new System.Drawing.Point(0, 0);
            this.cbSoftwareList.Name = "cbSoftwareList";
            this.cbSoftwareList.Size = new System.Drawing.Size(306, 21);
            this.cbSoftwareList.TabIndex = 0;
            // 
            // DeleteSoftwareControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbSoftwareList);
            this.Name = "DeleteSoftwareControl";
            this.Size = new System.Drawing.Size(306, 23);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSoftwareList;
    }
}
