using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;

namespace Licensing
{
    class cPCListView
    {
        public void InitaliseListView(ListView lvListView)
        {
            lvListView.View = View.Details;
            lvListView.Columns.Add("HS Tag", 50);
            lvListView.Columns.Add("Allocated To", 150);
            lvListView.Columns.Add("Type", 65);
            lvListView.Columns.Add("TypeID", 0);
        }

        public void PopulateListView(ListView lvListView)
        {
            string sql = "SELECT hs_tag, allocated_to, pc_type FROM pcs";
            SqlConnection cxn = new SqlConnection(Properties.Resources.connectionString);
            cxn.Open();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand(sql, cxn);
            myReader = myCommand.ExecuteReader();
            // Iterates through the records and adds them to the ListView
            while (myReader.Read())
            {
                var item = new ListViewItem();
                item.Text = myReader["hs_tag"].ToString();
                item.SubItems.Add(myReader["allocated_to"].ToString());
                switch (myReader["pc_type"].ToString())
                {
                    case "1":
                        item.SubItems.Add("Desktop");
                        item.SubItems[0].ForeColor = Color.Red;
                        break;
                    case "2":
                        item.SubItems.Add("Laptop");
                        item.SubItems[0].ForeColor = Color.Blue;
                        break;
                    case "3":
                        item.SubItems.Add("Server");
                        item.SubItems[0].ForeColor = Color.DarkGreen;
                        break;
                    case "4":
                        item.SubItems.Add("Virtual");
                        item.SubItems[0].ForeColor = Color.DarkOrange;
                        break;
                    case "5":
                        item.SubItems.Add("Embedded");
                        item.SubItems[0].ForeColor = Color.DarkSlateBlue;
                        break;
                }
                item.SubItems.Add(myReader["pc_type"].ToString());
                lvListView.Items.Add(item);
            }
            cxn.Close();
        }
    }
}
