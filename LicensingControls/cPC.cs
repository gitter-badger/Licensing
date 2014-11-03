using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicensingControls
{

    public class cPC
    {
        
        #region Data Fields
        public string hs_tag { get; set; }
        public string name { get; set; }
        public string manfacturer { get; set; }
        public string model { get; set; }
        public string serial_no { get; set; }
        public int oem_os_sw_id { get; set; }
        public string oem_os_key { get; set; }
        public string allocated_to { get; set; }
        public bool is_main_machine { get; set; } //
        public string ip { get; set; }
        public string comment { get; set; }
        public bool in_use { get; set; } //
        public DateTime purchase_date { get; set; }
        public DateTime warranty_end_date { get; set; }
        public string cpu { get; set; }
        public string memory { get; set; }
        public string disks { get; set; }
        public string graphics { get; set; }
        public int ip_type { get; set; }
        public string mac { get; set; }
        public DateTime last_audit_date { get; set; }
        public int pc_type { get; set; }
        public int os_bit { get; set; }
        public string bios { get; set; }
        public string wireless_mac { get; set; }
        public string host_pc { get; set; }
        #endregion

        public cPC()
        {
        }

        /// <summary>
        ///     Gets the PC information from the database using the argument
        ///     strAsset (the asset tag) and updates the class properties.
        /// </summary>
        /// <param name="strAsset">String: PC asset tag</param>
        public void Populate(string strAsset)
        {
            string strSQL = @"SELECT hs_tag, name, manufacturer, model, serial_no, oem_os_sw_id,
                oem_os_key, allocated_to, is_main_machine, ip, comment, in_use, purchase_date,
                warranty_end_date, cpu, memory, disks, graphics, ip_type, mac, last_audit_date,
                pc_type, os_bit, bios, wireless_mac, host_pc
                FROM pcs
                WHERE hs_tag = " + strAsset;

            using (SqlConnection objCxn = new SqlConnection(LicensingControls.Properties.Resources.ConnectionString))
            {
                objCxn.Open();
                using (SqlCommand objCommnd = new SqlCommand(strSQL, objCxn))
                {
                    SqlDataReader objReader = objCommnd.ExecuteReader();
                    while (objReader.Read())
                    {
                        try
                        {
                            hs_tag = objReader["hs_tag"].ToString();
                            name = objReader["name"].ToString();
                            manfacturer = objReader["manufacturer"].ToString();
                            model = objReader["model"].ToString();
                            serial_no = objReader["serial_no"].ToString();
                            oem_os_sw_id = Convert.ToInt32(objReader["oem_os_sw_id"]);
                            oem_os_key = objReader["oem_os_key"].ToString();
                            memory = objReader["memory"].ToString();
                            cpu = objReader["cpu"].ToString();
                            graphics = objReader["graphics"].ToString();
                            disks = objReader["disks"].ToString();
                            allocated_to = objReader["allocated_to"].ToString();
                            bios = objReader["bios"].ToString();
                            ip = objReader["ip"].ToString();
                            ip_type = Convert.ToInt32(objReader["ip_type"]);
                            mac = objReader["mac"].ToString();
                            wireless_mac = objReader["wireless_mac"].ToString();
                            purchase_date = (DateTime)objReader["purchase_date"];
                            warranty_end_date = (DateTime)objReader["warranty_end_date"];
                            last_audit_date = (DateTime)objReader["last_audit_date"];
                            os_bit = (Int32)objReader["os_bit"];
                            pc_type = Convert.ToInt32(objReader["pc_type"]);
                            is_main_machine = (bool)objReader["is_main_machine"];
                            in_use = (bool)objReader["in_use"];
                            comment = objReader["comment"].ToString();
                            host_pc = objReader["host_pc"].ToString();
                        }
                        catch { }
                    }
                }
            }
        }

        /// <summary>
        ///     Saves the PC information into the database table.
        /// </summary>
        public void Save()
        {

        }

        /// <summary>
        ///     Checks to see if the is_use variable is true or false
        ///     and checks a checkbox accordingly.
        /// </summary>
        /// <param name="chbCheckBox"></param>
        public void CheckInUse(CheckBox chbCheckBox)
        {
            if (in_use == true) chbCheckBox.Checked = true;
            else chbCheckBox.Checked = false;
        }

        /// <summary>
        ///     Checks to see if the is_main_machine variable is true or
        ///     false and check a checkbox accordingly.
        /// </summary>
        /// <param name="chbCheckBox"></param>
        public void CheckMainMachine(CheckBox chbCheckBox)
        {
            if (is_main_machine == true) chbCheckBox.Checked = true;
            else chbCheckBox.Checked = false;
        }

    }
}