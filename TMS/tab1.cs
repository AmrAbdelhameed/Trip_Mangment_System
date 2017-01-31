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
namespace TMS
{
    public partial class tab2 : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-OEMOTGQ;Integrated Security=SSPI;Initial Catalog=TMS");
        public int id_trav;
        public tab2()
        {
            InitializeComponent();
        }


        private void city_Enter(object sender, EventArgs e)
        {
            city.Text = "";
        }

        private void hotel_Click(object sender, EventArgs e)
        {
            if (city.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("search_city_id", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@cityname", this.city.Text));
                    int id = (int)cmd.ExecuteScalar();
                    tab51.city_id = id;
                    tab51.traveller_id = id_trav;
                    tab51.Visible = true;
                    tab51.BringToFront();
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("there is no city with this name in the data base");
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Enter City");
            }
        }
    }
}
