namespace LicensingControls
{
    partial class NewSoftwareControl
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
            this.tbSoftwareName = new System.Windows.Forms.TextBox();
            this.chbSoftwareControlled = new System.Windows.Forms.CheckBox();
            this.cbSoftwareType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbSoftwareName
            // 
            this.tbSoftwareName.Location = new System.Drawing.Point(3, 16);
            this.tbSoftwareName.Name = "tbSoftwareName";
            this.tbSoftwareName.Size = new System.Drawing.Size(270, 20);
            this.tbSoftwareName.TabIndex = 0;
            // 
            // chbSoftwareControlled
            // 
            this.chbSoftwareControlled.AutoSize = true;
            this.chbSoftwareControlled.Location = new System.Drawing.Point(3, 42);
            this.chbSoftwareControlled.Name = "chbSoftwareControlled";
            this.chbSoftwareControlled.Size = new System.Drawing.Size(174, 17);
            this.chbSoftwareControlled.TabIndex = 1;
            this.chbSoftwareControlled.Text = "This software requires a license";
            this.chbSoftwareControlled.UseVisualStyleBackColor = true;
            // 
            // cbSoftwareType
            // 
            this.cbSoftwareType.FormattingEnabled = true;
            this.cbSoftwareType.Items.AddRange(new object[] {
            "Operating System",
            "Application",
            "User Tool",
            "User Personal"});
            this.cbSoftwareType.Location = new System.Drawing.Point(279, 15);
            this.cbSoftwareType.Name = "cbSoftwareType";
            this.cbSoftwareType.Size = new System.Drawing.Size(121, 21);
            this.cbSoftwareType.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Software Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Software Type";
            // 
            // NewSoftwareControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSoftwareType);
            this.Controls.Add(this.chbSoftwareControlled);
            this.Controls.Add(this.tbSoftwareName);
            this.Name = "NewSoftwareControl";
            this.Size = new System.Drawing.Size(403, 62);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSoftwareName;
        private System.Windows.Forms.CheckBox chbSoftwareControlled;
        private System.Windows.Forms.ComboBox cbSoftwareType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
