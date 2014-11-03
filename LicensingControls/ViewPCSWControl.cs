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
    public partial class ViewPCSWControl : UserControl
    {
        public ViewPCSWControl()
        {
            InitializeComponent();
        }

        public string strHSAsset { get; set; }
        public void SetAssetTag(string strHSAssetNew) { strHSAsset = strHSAssetNew; }

        public void Initialise()
        {
            lvInstalledSoftware.Clear();
            lvInstalledSoftware.View = View.Details;
            // lvInstalledSoftware.CheckBoxes = true;

            // lvInstalledSoftware.Columns.Add("Installed", 53);
            lvInstalledSoftware.Columns.Add("Software", 205);
            lvInstalledSoftware.Columns.Add("Key", 205);
        }

        public void Populate()
        {
            Initialise();
            string sql = "SELECT sw_id, license_type, sw_key FROM pc_sw WHERE hs_tag=" + strHSAsset;
            using (SqlConnection cxn = new SqlConnection(LicensingControls.Properties.Resources.ConnectionString))
            {
                cxn.Open();
                using (SqlCommand command = new SqlCommand(sql, cxn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new ListViewItem();

                            // item.Checked = true;
                            item.Text = reader["sw_id"].ToString();
                            // item.SubItems.Add(reader["sw_id"].ToString());
                            item.SubItems.Add(reader["sw_key"].ToString());
                            lvInstalledSoftware.Items.Add(item);

                        }
                    }
                }
            }
            RewriteSoftwareNames();
        }

        private void RewriteSoftwareNames()
        {
            foreach (ListViewItem item in lvInstalledSoftware.Items)
            {
                string sw_id = item.SubItems[0].Text;
                using (SqlConnection cxn = new SqlConnection(LicensingControls.Properties.Resources.ConnectionString))
                {
                    cxn.Open();
                    string sql = "SELECT sw_name FROM sw WHERE sw_id=" + sw_id;
                    SqlCommand command = new SqlCommand(sql, cxn);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            item.SubItems[0].Text = reader["sw_name"].ToString();
                        }
                    }
                }
            }
        }
    }
}
