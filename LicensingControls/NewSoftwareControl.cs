using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LicensingControls
{
    public partial class NewSoftwareControl : UserControl
    {
        public NewSoftwareControl()
        {
            InitializeComponent();
        }

        cCommon cCommon = new cCommon();

        public void PopulateFields(string strSoftwareName)
        {
            cSoftware cSoftware = new cSoftware();
            cSoftware.PopulateObjectByName(strSoftwareName);
            chbSoftwareControlled.Checked = cSoftware.sw_controlled;
            tbSoftwareName.Text = cSoftware.sw_name;
            cbSoftwareType.Text = cCommon.ConvertSoftwareTypeIntToStr(cSoftware.sw_type);
        }

        public void InvokeAddNewSoftware()
        {
            cSoftware cSoftware = new cSoftware();
            cSoftware.sw_controlled = chbSoftwareControlled.Checked;
            cSoftware.sw_type = cCommon.ConvertSoftwareTypeStrToInt(cbSoftwareType.Text);
            cSoftware.sw_name = tbSoftwareName.Text;

            cSoftware.AddNewSoftware();
        }

        public void InvokeUpdateSoftware()
        {
            cSoftware cSoftware = new cSoftware();
            cSoftware.sw_controlled = chbSoftwareControlled.Checked;
            cSoftware.sw_type = cCommon.ConvertSoftwareTypeStrToInt(cbSoftwareType.Text);
            cSoftware.sw_name = tbSoftwareName.Text;

            cSoftware.UpdateSoftware();
        }
    }
}
