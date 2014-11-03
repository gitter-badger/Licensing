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
    public partial class LicensingControl: UserControl
    {
        string strCxnString = @"Data Source=VSOS5\;Initial Catalog=licenses;Persist Security Info=True;User ID=LicenseAdmin;Password=LicenseAdmin";

        cPC objPC = new cPC();
        cCommon objCommon = new cCommon();

        public LicensingControl()
        {
            InitializeComponent();
        }

        public void PopulateFields(string strAsset)
        {
            ClearCheckBoxes(); // Removes the state of in_use and is_main_machine

            objPC.Populate(strAsset);

            tbAsset.Text = objPC.hs_tag;
            tbName.Text = objPC.name;
            tbAllocatedTo.Text = objPC.allocated_to;
            tbModel.Text = objPC.model;
            tbMemory.Text = objPC.memory;
            tbManufacturer.Text = objPC.manfacturer;
            tbIPAddr.Text = objPC.ip;
            tbSerial.Text = objPC.serial_no;
            tbCPU.Text = objPC.cpu;
            tbGraphics.Text = objPC.graphics;
            tbStorage.Text = objPC.disks;
            tbWiredMAC.Text = objPC.mac;
            tbWirelessMac.Text = objPC.wireless_mac;
            tbOEMOSKey.Text = objPC.oem_os_key;
            tbComments.Text = objPC.comment;
            cbHostPC.Text = objPC.host_pc;
            dtLastAuditDate.Value = objPC.last_audit_date;
            dtPurchaseDate.Value = objPC.purchase_date;
            dtWarrantyEnd.Value = objPC.warranty_end_date;

            // Attempting to get the control working properly
            /*
            if (objPC.is_main_machine == true) chbMainMachine.Checked = true;
            if (objPC.in_use == true) chbInUse.Checked = true;

            switch (objPC.pc_type)
            {
                default: cbPCType.SelectedIndex = 0; break;
                case 1: cbPCType.SelectedIndex = 0; break;
                case 2: cbPCType.SelectedIndex = 1; break;
                case 3: cbPCType.SelectedIndex = 2; break;
                case 4: cbPCType.SelectedIndex = 3; break;
                case 5: cbPCType.SelectedIndex = 4; break;
            }
            // cbPCType.Text = objPC.pc_type.ToString();
            */

            // Load ComboBox Information
            objCommon.LoadAllOperatingSystems(cbOEMOSID);
        }

        /*
        public void WriteToDatabase()
        {
            string selected_pc = tbAsset.Text;
            #region SQL Command
            string sql = @"UPDATE pcs SET
                hs_tag=@hs_tag, name=@name, manufacturer=@manufacturer, model=@model, serial_no=@serial_no,
                oem_os_sw_id=@oem_os_sw_id, oem_os_key=@oem_os_key, allocated_to=@allocated_to,
                is_main_machine=@is_main_machine, ip=@ip, comment=@comment, in_use=@in_use, purchase_date=@purchase_date,
                warranty_end_date=@warranty_end_date, cpu=@cpu, memory=@memory, disks=@disks,
                graphics=@graphics, ip_type=@ip_type, mac=@mac, last_audit_date=@last_audit_date,
                pc_type=@pc_type, os_bit=@os_bit, bios=@bios, wireless_mac=@wireless_mac, host_pc=@host_pc 
                WHERE hs_tag='" + selected_pc + "'";
            #endregion 

            using (SqlConnection cxn = new SqlConnection(strCxnString))
            {
                cxn.Open();
                using (SqlCommand command = new SqlCommand(sql, cxn))
                {
                    command.Parameters.Add("@hs_tag", SqlDbType.VarChar).Value = objPC.hs_tag;
                    command.Parameters.Add("@name", SqlDbType.VarChar).Value = objPC.name;
                    command.Parameters.Add("@manufacturer", SqlDbType.VarChar).Value = objPC.manfacturer;
                    command.Parameters.Add("@model", SqlDbType.VarChar).Value = objPC.model;
                    command.Parameters.Add("@serial_no", SqlDbType.VarChar).Value = objPC.serial_no;
                    command.Parameters.Add("@oem_os_sw_id", SqlDbType.Int).Value = objPC.oem_os_sw_id;
                    command.Parameters.Add("@oem_sw_key", SqlDbType.VarChar).Value = objPC.oem_os_key;
                    command.Parameters.Add("@allocated_to", SqlDbType.VarChar).Value = objPC.allocated_to;
                    command.Parameters.Add("@is_main_machine", SqlDbType.Bit).Value = objPC.is_main_machine;
                }
            }
        }
        */

        private void LicensingControl_Load(object sender, EventArgs e)
        {
            objCommon.GetListOfMachineNames(cbHostPC);
        }

        private void ClearCheckBoxes()
        {
            chbInUse.Checked = false;
            chbMainMachine.Checked = false;
        }
    }
}
