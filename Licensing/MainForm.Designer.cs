namespace Licensing
{
    partial class MainForm
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
            this.lvPCListView = new System.Windows.Forms.ListView();
            this.bSave = new System.Windows.Forms.Button();
            this.bAddNewPC = new System.Windows.Forms.Button();
            this.bAddDBSoftware = new System.Windows.Forms.Button();
            this.bModDBSoftware = new System.Windows.Forms.Button();
            this.bDelDBSoftware = new System.Windows.Forms.Button();
            this.bThisPC = new System.Windows.Forms.Button();
            this.bPCSoftware = new System.Windows.Forms.Button();
            this.ucViewPCSWControl = new LicensingControls.ViewPCSWControl();
            this.ucLicensingControl = new LicensingControls.LicensingControl();
            this.bClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvPCListView
            // 
            this.lvPCListView.FullRowSelect = true;
            this.lvPCListView.Location = new System.Drawing.Point(12, 12);
            this.lvPCListView.Name = "lvPCListView";
            this.lvPCListView.Size = new System.Drawing.Size(291, 557);
            this.lvPCListView.TabIndex = 1;
            this.lvPCListView.UseCompatibleStateImageBehavior = false;
            this.lvPCListView.View = System.Windows.Forms.View.Details;
            this.lvPCListView.SelectedIndexChanged += new System.EventHandler(this.lvPCListView_SelectedIndexChanged);
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bSave.FlatAppearance.BorderSize = 0;
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.Location = new System.Drawing.Point(394, 636);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 39);
            this.bSave.TabIndex = 8;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = false;
            // 
            // bAddNewPC
            // 
            this.bAddNewPC.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bAddNewPC.FlatAppearance.BorderSize = 0;
            this.bAddNewPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddNewPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddNewPC.Location = new System.Drawing.Point(313, 690);
            this.bAddNewPC.Name = "bAddNewPC";
            this.bAddNewPC.Size = new System.Drawing.Size(75, 42);
            this.bAddNewPC.TabIndex = 9;
            this.bAddNewPC.Text = "Add New PC";
            this.bAddNewPC.UseVisualStyleBackColor = false;
            this.bAddNewPC.Click += new System.EventHandler(this.bAddNewPC_Click);
            // 
            // bAddDBSoftware
            // 
            this.bAddDBSoftware.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bAddDBSoftware.FlatAppearance.BorderSize = 0;
            this.bAddDBSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddDBSoftware.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddDBSoftware.Location = new System.Drawing.Point(394, 690);
            this.bAddDBSoftware.Name = "bAddDBSoftware";
            this.bAddDBSoftware.Size = new System.Drawing.Size(75, 42);
            this.bAddDBSoftware.TabIndex = 10;
            this.bAddDBSoftware.Text = "Add DB Software";
            this.bAddDBSoftware.UseVisualStyleBackColor = false;
            this.bAddDBSoftware.Click += new System.EventHandler(this.bAddDBSoftware_Click);
            // 
            // bModDBSoftware
            // 
            this.bModDBSoftware.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bModDBSoftware.FlatAppearance.BorderSize = 0;
            this.bModDBSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bModDBSoftware.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModDBSoftware.Location = new System.Drawing.Point(475, 690);
            this.bModDBSoftware.Name = "bModDBSoftware";
            this.bModDBSoftware.Size = new System.Drawing.Size(75, 42);
            this.bModDBSoftware.TabIndex = 11;
            this.bModDBSoftware.Text = "Modify DB Software";
            this.bModDBSoftware.UseVisualStyleBackColor = false;
            // 
            // bDelDBSoftware
            // 
            this.bDelDBSoftware.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bDelDBSoftware.FlatAppearance.BorderSize = 0;
            this.bDelDBSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDelDBSoftware.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelDBSoftware.Location = new System.Drawing.Point(556, 690);
            this.bDelDBSoftware.Name = "bDelDBSoftware";
            this.bDelDBSoftware.Size = new System.Drawing.Size(75, 42);
            this.bDelDBSoftware.TabIndex = 12;
            this.bDelDBSoftware.Text = "Delete DB Software";
            this.bDelDBSoftware.UseVisualStyleBackColor = false;
            this.bDelDBSoftware.Click += new System.EventHandler(this.bDelDBSoftware_Click);
            // 
            // bThisPC
            // 
            this.bThisPC.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bThisPC.FlatAppearance.BorderSize = 0;
            this.bThisPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bThisPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bThisPC.Location = new System.Drawing.Point(475, 636);
            this.bThisPC.Name = "bThisPC";
            this.bThisPC.Size = new System.Drawing.Size(75, 39);
            this.bThisPC.TabIndex = 13;
            this.bThisPC.Text = "Select This PC";
            this.bThisPC.UseVisualStyleBackColor = false;
            // 
            // bPCSoftware
            // 
            this.bPCSoftware.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bPCSoftware.FlatAppearance.BorderSize = 0;
            this.bPCSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPCSoftware.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPCSoftware.Location = new System.Drawing.Point(556, 636);
            this.bPCSoftware.Name = "bPCSoftware";
            this.bPCSoftware.Size = new System.Drawing.Size(75, 39);
            this.bPCSoftware.TabIndex = 14;
            this.bPCSoftware.Text = "Manage PC Software";
            this.bPCSoftware.UseVisualStyleBackColor = false;
            // 
            // ucViewPCSWControl
            // 
            this.ucViewPCSWControl.Location = new System.Drawing.Point(12, 575);
            this.ucViewPCSWControl.Name = "ucViewPCSWControl";
            this.ucViewPCSWControl.Size = new System.Drawing.Size(291, 165);
            this.ucViewPCSWControl.strHSAsset = null;
            this.ucViewPCSWControl.TabIndex = 2;
            // 
            // ucLicensingControl
            // 
            this.ucLicensingControl.Location = new System.Drawing.Point(309, 12);
            this.ucLicensingControl.Name = "ucLicensingControl";
            this.ucLicensingControl.Size = new System.Drawing.Size(446, 618);
            this.ucLicensingControl.TabIndex = 0;
            // 
            // bClose
            // 
            this.bClose.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bClose.FlatAppearance.BorderSize = 0;
            this.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Location = new System.Drawing.Point(637, 690);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 42);
            this.bClose.TabIndex = 15;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = false;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 744);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bPCSoftware);
            this.Controls.Add(this.bThisPC);
            this.Controls.Add(this.bDelDBSoftware);
            this.Controls.Add(this.bModDBSoftware);
            this.Controls.Add(this.bAddDBSoftware);
            this.Controls.Add(this.bAddNewPC);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.ucViewPCSWControl);
            this.Controls.Add(this.lvPCListView);
            this.Controls.Add(this.ucLicensingControl);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Harland Simon Plc - Licensing";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LicensingControls.LicensingControl ucLicensingControl;
        private System.Windows.Forms.ListView lvPCListView;
        private LicensingControls.ViewPCSWControl ucViewPCSWControl;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bAddNewPC;
        private System.Windows.Forms.Button bAddDBSoftware;
        private System.Windows.Forms.Button bModDBSoftware;
        private System.Windows.Forms.Button bDelDBSoftware;
        private System.Windows.Forms.Button bThisPC;
        private System.Windows.Forms.Button bPCSoftware;
        private System.Windows.Forms.Button bClose;
    }
}