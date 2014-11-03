namespace Licensing
{
    partial class AddNewPC
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
            this.bSubmit = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.ucNewPCControl = new LicensingControls.NewPCControl();
            this.SuspendLayout();
            // 
            // bSubmit
            // 
            this.bSubmit.Location = new System.Drawing.Point(10, 119);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(75, 23);
            this.bSubmit.TabIndex = 1;
            this.bSubmit.Text = "Submit";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(305, 119);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 2;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // ucNewPCControl
            // 
            this.ucNewPCControl.Location = new System.Drawing.Point(10, 12);
            this.ucNewPCControl.Name = "ucNewPCControl";
            this.ucNewPCControl.Size = new System.Drawing.Size(370, 101);
            this.ucNewPCControl.TabIndex = 3;
            // 
            // AddNewPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 150);
            this.Controls.Add(this.ucNewPCControl);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSubmit);
            this.Name = "AddNewPC";
            this.Text = "Add a new PC to the database";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.Button bCancel;
        private LicensingControls.NewPCControl ucNewPCControl;

    }
}