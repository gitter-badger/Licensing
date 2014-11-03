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
using LicensingControls;

namespace LicensingControls
{
    public partial class NewPCControl : UserControl
    {
        public NewPCControl()
        {
            InitializeComponent();
        }

        cCommon cCommon = new cCommon();

        private void NewPCControl_Load(object sender, EventArgs e)
        {
            cCommon.LoadAllOperatingSystems(cbOSName);
        }

        public void AddNewPC()
        {
            // Gets all the information from the control
            bool is_main_machine = cbIsMainMachine.Checked;
            string name = tbPCName.Text;
            string hs_tag = tbHSAsset.Text;
            string allocated_to = tbAllocated.Text;
            string pc_type = cbPCType.SelectedItem.ToString();
            string os_bit = cbOSBit.SelectedItem.ToString();

            // Gets the OS Name, converts to int and updates cPC datafield [oem_os_sw_id]
            string os_name = cbOSName.SelectedItem.ToString();
            int intOS = Int32.Parse(cCommon.GetIDFromSoftware(os_name));
            int oem_os_sw_id = intOS;

            // Convert the os_name into integer and insert into the database

            using (SqlConnection cxn = new SqlConnection(LicensingControls.Properties.Resources.ConnectionString))
            {
                cxn.Open();
                string sql = @"INSERT INTO pcs(hs_tag, name, oem_os_sw_id, allocated_to, is_main_machine, pc_type, os_bit) " +
                    "VALUES(@hs_tag, @name, @oem_os_sw_id, @allocated_to, @is_main_machine, @pc_type, @os_bit)";

                SqlCommand cmd = new SqlCommand(sql, cxn);
                cmd.Parameters.Add("@hs_tag", SqlDbType.VarChar, 10).Value = hs_tag;
                cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = name;
                cmd.Parameters.Add("@oem_os_sw_id", SqlDbType.Int).Value = oem_os_sw_id;
                cmd.Parameters.Add("@allocated_to", SqlDbType.VarChar, 50).Value = allocated_to;
                if (is_main_machine == true)
                    cmd.Parameters.Add("@is_main_machine", SqlDbType.Bit).Value = true;
                else
                    cmd.Parameters.Add("@is_main_machine", SqlDbType.Bit).Value = false;

                cmd.Parameters.Add("@pc_type", SqlDbType.Int).Value = cCommon.ConvertPCTypeStrToInt(pc_type);
                cmd.Parameters.Add("@os_bit", SqlDbType.Int).Value = os_bit;

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }

        }
    }
}
