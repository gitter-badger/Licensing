using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicensingControls
{
    class cSoftware
    {
       
        public int sw_id { get; set; }
        public string sw_name { get; set; }
        public int sw_type { get; set; }
        public bool sw_controlled { get; set; }

        cCommon cCommon = new cCommon();

        public cSoftware()
        {
        }

        /// <summary>
        ///     Gets all the information about a specific software and
        ///     updates the classes attributes.
        /// </summary>
        /// <param name="strSWName">Software Name</param>
        public void PopulateObjectByName(string strSWName)
        {
            using (SqlConnection cxn = new SqlConnection(LicensingControls.Properties.Resources.ConnectionString))
            {
                string strSQL = "SELECT * FROM sw WHERE sw_name='" + strSWName + "'";
                cxn.Open();
                using (SqlCommand command = new SqlCommand(strSQL, cxn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sw_id = (Int32)reader["sw_id"];
                            sw_name = reader["sw_name"].ToString();
                            sw_type = (Int32)reader["sw_type"];
                            sw_controlled = (bool)reader["sw_controlled"];
                        }
                    }
                }
            }
        }

        /// <summary>
        ///     Adds a new new piece of software into the sw table in the licensing
        ///     database. Uses the classes attributed as information.
        /// </summary>
        public void AddNewSoftware()
        {
            string sql = @"INSERT INTO sw (sw_name, sw_type, sw_controlled) VALUES (@sw_name, @sw_type, @sw_controlled)";
            SqlConnection cxn = new SqlConnection(LicensingControls.Properties.Resources.ConnectionString);
            cxn.Open();

            SqlCommand command = new SqlCommand(sql, cxn);
            command.Parameters.Add("@sw_name", SqlDbType.VarChar, 100).Value = sw_name;
            command.Parameters.Add("@sw_type", SqlDbType.Int, 100).Value = sw_type;
            command.Parameters.Add("@sw_controlled", SqlDbType.Bit, 100).Value = sw_controlled;

            command.ExecuteNonQuery();
            cxn.Close();
        }

        /// <summary>
        ///     Updates a record in the database.
        /// </summary>
        public void UpdateSoftware()
        {
            SqlConnection cxn = new SqlConnection(LicensingControls.Properties.Resources.ConnectionString);
            cxn.Open();
            string sql = @"UPDATE sw SET sw_name=@sw_name, sw_type=@sw_type, sw_controlled=@sw_controlled WHERE sw_name=@sw_name";

            SqlCommand command = new SqlCommand(sql, cxn);
            command.Parameters.AddWithValue("@sw_name", SqlDbType.VarChar).Value = sw_name;
            command.Parameters.AddWithValue("@sw_type", SqlDbType.Int).Value = sw_type;
            command.Parameters.AddWithValue("@sw_controlled", SqlDbType.Bit).Value = sw_controlled;

            command.ExecuteNonQuery();
            cxn.Close();
        }
    }
}
