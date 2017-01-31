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
    public partial class tab5 : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-OEMOTGQ;Integrated Security=SSPI;Initial Catalog=TMS");
        public int city_id,traveller_id;
        public tab5()
        {
            InitializeComponent();
           
        }


        private void back_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            dataGridView1.DataSource = tbl;
            name.Text = "";
            star.Text = "";
            phone.Text = "";
            rate.Text = "";
            pn.Text = "";
            avrooom.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            this.Hide();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("search_hotel", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", city_id));
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name");
            tbl.Columns.Add("star");
            tbl.Columns.Add("phone");
            tbl.Columns.Add("rate");
            tbl.Columns.Add("price_per_night");
            tbl.Columns.Add("avilable_rooms");
            DataRow row;
            while (reader.Read())
            {
                row = tbl.NewRow();
                row["Name"] = reader["Name"];
                row["star"] = reader["star"];
                row["phone"] = reader["phone"];
                row["rate"] = reader["rate"];
                row["price_per_night"] = reader["price_per_night"];
                row["avilable_rooms"] = reader["avilable_rooms"];
                tbl.Rows.Add(row);
            }
            reader.Close();
            con.Close();
            dataGridView1.DataSource = tbl;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                name.Text = row.Cells["Name"].Value.ToString();
                star.Text = row.Cells["star"].Value.ToString();
                phone.Text = row.Cells["phone"].Value.ToString();
                rate.Text = row.Cells["rate"].Value.ToString();
                pn.Text = row.Cells["price_per_night"].Value.ToString();
                avrooom.Text = row.Cells["avilable_rooms"].Value.ToString();
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string insert_feedback = @"insert into feedback (traveller_id,Name_hotel,review_hotel,rate_hotel) values(@straveller_id,@sName_hotel,@sreview_hotel,@srate_hotel)";
            SqlCommand cmd = new SqlCommand(insert_feedback, con);
            SqlParameter paramtravellerid = new SqlParameter("@straveller_id", traveller_id);
            cmd.Parameters.Add(paramtravellerid);
            SqlParameter paramName_hotel = new SqlParameter("@sName_hotel", name.Text);
            cmd.Parameters.Add(paramName_hotel);
            SqlParameter paramreview_hotel = new SqlParameter("@sreview_hotel", textBox2.Text);
            cmd.Parameters.Add(paramreview_hotel);
            SqlParameter paramrate_hotel = new SqlParameter("@srate_hotel", textBox1.Text);
            cmd.Parameters.Add(paramrate_hotel);
            cmd.ExecuteNonQuery();


            string bil = ("select bill from Profile where id_traveller=@straveller ");
                 SqlCommand cmd3 = new SqlCommand(bil, con);
            SqlParameter p = new SqlParameter("@straveller", traveller_id);
            cmd3.Parameters.Add(p);
            SqlDataReader dr;
            int bill=0;
            dr = cmd3.ExecuteReader(); 
            int count = 0;
            while (dr.Read())
            {
                count += 1;
            }
            if (count >= 1)
            { dr.Close(); bill = (int)cmd3.ExecuteScalar(); }

            dr.Close();
            string curpn = ("select price_per_night from hotel where Name=@sname ");
            SqlCommand cmd4 = new SqlCommand(curpn, con);
            SqlParameter praname = new SqlParameter("@sname", name.Text);
            cmd4.Parameters.Add(praname);
            int current_pn = (int)cmd4.ExecuteScalar();
            bill += current_pn;


            string insert_profile = @"insert into Profile (id_traveller,hotel_name) values(@straveller_id,@sName_hotel)";
            SqlCommand cmd2 = new SqlCommand(insert_profile, con);
            SqlParameter paramtraveller = new SqlParameter("@straveller_id", traveller_id);
            cmd2.Parameters.Add(paramtraveller);
            SqlParameter paramName_ho = new SqlParameter("@sName_hotel", name.Text);
            cmd2.Parameters.Add(paramName_ho);

            cmd2.ExecuteNonQuery();

            string upd_bil = @"update Profile set bill=@sbill where id_traveller=@straveller_id";
            SqlCommand cmd5 = new SqlCommand(upd_bil, con);
            SqlParameter paramsbill = new SqlParameter("@sbill", bill);
            cmd5.Parameters.Add(paramsbill);
            SqlParameter paramtrave = new SqlParameter("@straveller_id", traveller_id);
            cmd5.Parameters.Add(paramtrave);
            cmd5.ExecuteNonQuery();


            MessageBox.Show("You reserved a room in this Hotel ");
            con.Close();
        }
    }
}
