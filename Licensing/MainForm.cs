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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        cPCListView cPCListView = new cPCListView();

        private void MainForm_Load(object sender, EventArgs e)
        {
            cPCListView.InitaliseListView(lvPCListView);
            cPCListView.PopulateListView(lvPCListView);
            ucViewPCSWControl.Initialise();
        }

        private void lvPCListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ucViewPCSWControl.strHSAsset = lvPCListView.SelectedItems[0].Text;
                ucViewPCSWControl.Populate();
                ucLicensingControl.PopulateFields(lvPCListView.SelectedItems[0].Text);
            }
            catch
            {
            }
        }

        private void bDelDBSoftware_Click(object sender, EventArgs e)
        {

        }

        private void bAddNewPC_Click(object sender, EventArgs e)
        {
            AddNewPC AddNewPC = new AddNewPC();
            AddNewPC.ShowDialog();
        }

        private void bAddDBSoftware_Click(object sender, EventArgs e)
        {
            AddNewSoftware AddNewSoftware = new AddNewSoftware();
            AddNewSoftware.ShowDialog();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
