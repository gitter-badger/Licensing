using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicensingControls
{
    class cCommon
    {
        
        public cCommon() {

        }

        /// <summary>
        ///     Loads a list of Operating Systems into a ComboBox
        /// </summary>
        /// <param name="cbComboBox">ComboBox</param>
        public void LoadAllOperatingSystems(ComboBox cbComboBox)
        {
            string sql = "SELECT sw_name FROM sw WHERE sw_type=0";

            using (SqlConnection objCxn = new SqlConnection(LicensingControls.Properties.Resources.ConnectionString))
            {
                objCxn.Open();
                using (SqlCommand command = new SqlCommand(sql, objCxn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbComboBox.Items.Add(reader["sw_name"].ToString());
                        }
                    }
                }
            }
        }

        /// <summary>
        ///     Returns a software name (string) from a software ID
        /// </summary>
        /// <param name="strID">Software ID</param>
        /// <returns>Software Name</returns>
        public string GetSoftwareFromID(string strID)
        {
            string strSWName = "0";
            using (SqlConnection objCxn = new SqlConnection(LicensingControls.Properties.Resources.ConnectionString))
            {
                
                objCxn.Open();
                string strSQL = "SELECT sw_name FROM sw WHERE sw_id=" + strID;
                using (SqlCommand command = new SqlCommand(strSQL, objCxn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            strSWName = reader["sw_name"].ToString();
                        }
                    }
                }
                return strSWName;
            }
        }

        /// <summary>
        ///     Returns a software ID (string) from a software name
        /// </summary>
        /// <param name="strName">Software Name</param>
        /// <returns>Software ID</returns>
        public string GetIDFromSoftware(string strName)
        {
            string strSWID = "0";
            using (SqlConnection objCxn = new SqlConnection(LicensingControls.Properties.Resources.ConnectionString))
            {
                objCxn.Open();
                string strSQL = "SELECT sw_id FROM sw WHERE sw_name='" + strName + "'";
                using (SqlCommand command = new SqlCommand(strSQL, objCxn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            strSWID = reader["sw_id"].ToString();
                        }
                    }
                }
                return strSWID;
            }
        }

        /// <summary>
        ///     Checks a string that contains a boolean value and 
        ///     returns a boolean value with the correct datatype.
        /// </summary>
        /// <param name="strBool">string Boolean</param>
        /// <returns>bool Boolean</returns>
        public bool CheckBooleanValue(string strBool)
        {
            if (strBool == "True")
            {
                return true;
            }
            else
                return false;
        }

        /// <summary>
        ///     Counts how many instances of a software are insalled
        ///     on all machines.
        /// </summary>
        /// <param name="strSWID">string SoftwareID</param>
        /// <returns>int Count</returns>
        public int SoftwareCount(string strSWID)
        {
            string strSQL = "SELECT COUNT(hs_tag) AS Count FROM pc_sw WHERE sw_id=" + strSWID;
            using (SqlConnection cxn = new SqlConnection(LicensingControls.Properties.Resources.ConnectionString))
            {
                cxn.Open();
                using (SqlCommand command = new SqlCommand(strSQL, cxn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return (int)reader["Count"];
                        }
                    }
                }
            }
            return 0;
        }

        /// <summary>
        ///     Strips (MK) off of the PC Name
        /// </summary>
        /// <param name="strName">PC Name</param>
        /// <returns>Asset from the name</returns>
        public string GetAssetFromMKName(string strName)
        {
            return Regex.Match(strName, @"\d+").Value;
        }

        /// <summary>
        ///     Gets a list of PC names for the drop down list.
        /// </summary>
        /// <param name="cbComboBox">ComboBox</param>
        public void GetListOfMachineNames(ComboBox cbComboBox)
        {
            string strSQL = "SELECT name FROM pcs";
            using (SqlConnection cxn = new SqlConnection(LicensingControls.Properties.Resources.ConnectionString))
            {
                cxn.Open();
                using (SqlCommand command = new SqlCommand(strSQL, cxn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbComboBox.Items.Add(reader["name"].ToString());
                        }
                    }
                }
            }
        }

        /// <summary>
        ///     Converts the string representation of a software type
        ///     into it's database friendly int representation.
        /// </summary>
        /// <param name="strSoftware">PC Type</param>
        /// <returns>Desktop:1, Laptop:2, Server:3, Virtual:4, Embedded:5</returns>
        public int ConvertPCTypeStrToInt(string strPCType)
        {
            switch (strPCType)
            {
                default:
                case "Desktop": return 1;
                case "Laptop": return 2;
                case "Server": return 3;
                case "Virtual Machine": return 4;
                case "Embedded Machine": return 5;
            }
        }

        /// <summary>
        ///     Converts the software type from its string representation
        ///     to it's integer representation.
        /// </summary>
        /// <param name="strSWType">Software Type</param>
        /// <returns>Operating System: 0, Application: 1, User Tool: 2, User Personal: 3</returns>
        public int ConvertSoftwareTypeStrToInt(string strSWType)
        {
            switch (strSWType)
            {
                default:
                case "Operating System": return 0;
                case "Application": return 1;
                case "User Tool": return 2;
                case "User Personal": return 3;
            }
        }

        /// <summary>
        ///     Converts the software type from its integer representaion to
        ///     its string representation.
        /// </summary>
        /// <param name="intSWType">Software Type</param>
        /// <returns>Operating System: 0, Application: 1, User Tool: 2, User Personal: 3</returns>
        public string ConvertSoftwareTypeIntToStr(int intSWType)
        {
            switch (intSWType)
            {
                default:
                case 0: return "Operating System";
                case 1: return "Application";
                case 2: return "User Tool";
                case 3: return "User Personal";
            }
        }

        /// <summary>
        ///     Loads a list of installed software into a ComboBox
        /// </summary>
        /// <param name="strAsset">String</param>
        /// <param name="cbComboBox">ComboBox</param>
        public void LoadInstalledSoftware(string strAsset, ComboBox cbComboBox)
        {
            using (SqlConnection cxn = new SqlConnection(LicensingControls.Properties.Resources.ConnectionString))
            {
                string sql = "SELECT * FROM pc_sw WHERE hs_tag=" + strAsset;
                cxn.Open();
                using (SqlCommand command = new SqlCommand(sql, cxn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string strSWName = GetSoftwareFromID(reader["sw_id"].ToString());
                            cbComboBox.Items.Add(strSWName);
                        }
                    }
                }
            }
        }
    }
}
