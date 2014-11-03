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
    public partial class DeleteSoftwareControl : UserControl
    {
        public DeleteSoftwareControl()
        {
            InitializeComponent();
        }

        cCommon cCommon = new cCommon();

        public string strAsset { get; set; }

        public void PopulateFields()
        {
            cCommon.LoadInstalledSoftware(strAsset, cbSoftwareList);
        }
    }
}
