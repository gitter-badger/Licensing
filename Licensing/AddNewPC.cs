using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Licensing
{
    public partial class AddNewPC : Form
    {
        public AddNewPC()
        {
            InitializeComponent();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                ucNewPCControl.AddNewPC();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Please fill in all the controls on the form before pressing the submit button",
                    "Error: Could not write",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
