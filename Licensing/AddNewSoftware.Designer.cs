namespace Licensing
{
    partial class AddNewSoftware
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
            this.ucNewSoftwareControl = new LicensingControls.NewSoftwareControl();
            this.bSubmit = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucNewSoftwareControl
            // 
            this.ucNewSoftwareControl.Location = new System.Drawing.Point(12, 12);
            this.ucNewSoftwareControl.Name = "ucNewSoftwareControl";
            this.ucNewSoftwareControl.Size = new System.Drawing.Size(403, 62);
            this.ucNewSoftwareControl.TabIndex = 0;
            // 
            // bSubmit
            // 
            this.bSubmit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bSubmit.FlatAppearance.BorderSize = 0;
            this.bSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSubmit.Location = new System.Drawing.Point(259, 60);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(75, 23);
            this.bSubmit.TabIndex = 1;
            this.bSubmit.Text = "Submit";
            this.bSubmit.UseVisualStyleBackColor = false;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bCancel.FlatAppearance.BorderSize = 0;
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.Location = new System.Drawing.Point(340, 60);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 2;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // AddNewSoftware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 88);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.ucNewSoftwareControl);
            this.Name = "AddNewSoftware";
            this.Text = "Add a new Software";
            this.ResumeLayout(false);

        }

        #endregion

        private LicensingControls.NewSoftwareControl ucNewSoftwareControl;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.Button bCancel;
    }
}