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
    public partial class AddNewSoftware : Form
    {
        public AddNewSoftware()
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
                ucNewSoftwareControl.InvokeAddNewSoftware();
            }
            catch
            {
                MessageBox.Show("Please fill in all of the controls on the form and try again",
                    "Error: Could not write",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
