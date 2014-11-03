namespace LicensingControls
{
    partial class NewPCControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labela = new System.Windows.Forms.Label();
            this.tbHSAsset = new System.Windows.Forms.TextBox();
            this.tbPCName = new System.Windows.Forms.TextBox();
            this.tbAllocated = new System.Windows.Forms.TextBox();
            this.cbOSName = new System.Windows.Forms.ComboBox();
            this.cbOSBit = new System.Windows.Forms.ComboBox();
            this.cbIsMainMachine = new System.Windows.Forms.CheckBox();
            this.cbPCType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HS Asset:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "OS:";
            // 
            // labelb
            // 
            this.labelb.AutoSize = true;
            this.labelb.Location = new System.Drawing.Point(197, 29);
            this.labelb.Name = "labelb";
            this.labelb.Size = new System.Drawing.Size(51, 13);
            this.labelb.TabIndex = 2;
            this.labelb.Text = "PC Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Allocation:";
            // 
            // labela
            // 
            this.labela.AutoSize = true;
            this.labela.Location = new System.Drawing.Point(157, 3);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(55, 13);
            this.labela.TabIndex = 4;
            this.labela.Text = "PC Name:";
            // 
            // tbHSAsset
            // 
            this.tbHSAsset.Location = new System.Drawing.Point(63, 0);
            this.tbHSAsset.Name = "tbHSAsset";
            this.tbHSAsset.Size = new System.Drawing.Size(88, 20);
            this.tbHSAsset.TabIndex = 5;
            // 
            // tbPCName
            // 
            this.tbPCName.Location = new System.Drawing.Point(218, 0);
            this.tbPCName.Name = "tbPCName";
            this.tbPCName.Size = new System.Drawing.Size(149, 20);
            this.tbPCName.TabIndex = 6;
            // 
            // tbAllocated
            // 
            this.tbAllocated.Location = new System.Drawing.Point(63, 26);
            this.tbAllocated.Name = "tbAllocated";
            this.tbAllocated.Size = new System.Drawing.Size(128, 20);
            this.tbAllocated.TabIndex = 7;
            // 
            // cbOSName
            // 
            this.cbOSName.FormattingEnabled = true;
            this.cbOSName.Location = new System.Drawing.Point(63, 52);
            this.cbOSName.Name = "cbOSName";
            this.cbOSName.Size = new System.Drawing.Size(233, 21);
            this.cbOSName.TabIndex = 9;
            // 
            // cbOSBit
            // 
            this.cbOSBit.FormattingEnabled = true;
            this.cbOSBit.Items.AddRange(new object[] {
            "16",
            "32",
            "64",
            "128"});
            this.cbOSBit.Location = new System.Drawing.Point(302, 52);
            this.cbOSBit.Name = "cbOSBit";
            this.cbOSBit.Size = new System.Drawing.Size(65, 21);
            this.cbOSBit.TabIndex = 10;
            // 
            // cbIsMainMachine
            // 
            this.cbIsMainMachine.AutoSize = true;
            this.cbIsMainMachine.Location = new System.Drawing.Point(63, 79);
            this.cbIsMainMachine.Name = "cbIsMainMachine";
            this.cbIsMainMachine.Size = new System.Drawing.Size(102, 17);
            this.cbIsMainMachine.TabIndex = 11;
            this.cbIsMainMachine.Text = "Is main machine";
            this.cbIsMainMachine.UseVisualStyleBackColor = true;
            // 
            // cbPCType
            // 
            this.cbPCType.FormattingEnabled = true;
            this.cbPCType.Items.AddRange(new object[] {
            "Desktop",
            "Laptop",
            "Server",
            "Virtual",
            "Embedded"});
            this.cbPCType.Location = new System.Drawing.Point(254, 25);
            this.cbPCType.Name = "cbPCType";
            this.cbPCType.Size = new System.Drawing.Size(113, 21);
            this.cbPCType.TabIndex = 12;
            // 
            // NewPCControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbPCType);
            this.Controls.Add(this.cbIsMainMachine);
            this.Controls.Add(this.cbOSBit);
            this.Controls.Add(this.cbOSName);
            this.Controls.Add(this.tbAllocated);
            this.Controls.Add(this.tbPCName);
            this.Controls.Add(this.tbHSAsset);
            this.Controls.Add(this.labela);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewPCControl";
            this.Size = new System.Drawing.Size(370, 101);
            this.Load += new System.EventHandler(this.NewPCControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labela;
        private System.Windows.Forms.TextBox tbHSAsset;
        private System.Windows.Forms.TextBox tbPCName;
        private System.Windows.Forms.TextBox tbAllocated;
        private System.Windows.Forms.ComboBox cbOSName;
        private System.Windows.Forms.ComboBox cbOSBit;
        private System.Windows.Forms.CheckBox cbIsMainMachine;
        private System.Windows.Forms.ComboBox cbPCType;
    }
}
