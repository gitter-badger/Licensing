﻿namespace LicensingControls
{
    partial class ViewPCSWControl
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
            this.lvInstalledSoftware = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvInstalledSoftware
            // 
            this.lvInstalledSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvInstalledSoftware.Location = new System.Drawing.Point(0, 0);
            this.lvInstalledSoftware.Name = "lvInstalledSoftware";
            this.lvInstalledSoftware.Size = new System.Drawing.Size(350, 147);
            this.lvInstalledSoftware.TabIndex = 0;
            this.lvInstalledSoftware.UseCompatibleStateImageBehavior = false;
            // 
            // ViewPCSWControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvInstalledSoftware);
            this.Name = "ViewPCSWControl";
            this.Size = new System.Drawing.Size(350, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvInstalledSoftware;
    }
}
