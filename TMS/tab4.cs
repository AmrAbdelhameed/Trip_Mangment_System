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
    public partial class tab4 : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-OEMOTGQ;Integrated Security=SSPI;Initial Catalog=TMS");
        public int id_trav;
        public tab4()
        {
            InitializeComponent();
        }

      


        private void city_Enter(object sender, EventArgs e)
        {
            city.Text = "";
        }

        private void search_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(" SELECT  id  FROM city WHERE  name = @cityname", con);
            
            cmd.Parameters.Add(new SqlParameter("@cityname", this.city.Text));
            int id = (int)cmd.ExecuteScalar();
            tab_things1.city_id = id;
            tab_things1.traveller_id = id_trav;
            tab_things1.Visible = true;
            tab_things1.BringToFront();

            con.Close();
        }
    }
}
