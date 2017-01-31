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
    public partial class tab_things : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-OEMOTGQ;Integrated Security=SSPI;Initial Catalog=TMS");
        public int city_id, traveller_id;
        public tab_things()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT trip_num,museum,Parks,historic_sites,malls,beaches,rate,cost_trip   FROM things_to_do WHERE  city_id = @id", con);
            cmd.Parameters.Add(new SqlParameter("@id", city_id));
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Columns.Add("trip_num");
            tbl.Columns.Add("museum");
            tbl.Columns.Add("Parks");
            tbl.Columns.Add("historic_sites");
            tbl.Columns.Add("malls");
            tbl.Columns.Add("beaches");
            tbl.Columns.Add("rate");
            tbl.Columns.Add("cost_trip");
            DataRow row;
            while (reader.Read())
            {
                row = tbl.NewRow();
                row["trip_num"] = reader["trip_num"];
                row["museum"] = reader["museum"];
                row["Parks"] = reader["Parks"];
                row["historic_sites"] = reader["historic_sites"];
                row["malls"] = reader["malls"];
                row["beaches"] = reader["beaches"];
                row["rate"] = reader["rate"];
                row["cost_trip"] = reader["cost_trip"];
                tbl.Rows.Add(row);
            }
            reader.Close();
            con.Close();
            dataGridView1.DataSource = tbl;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                name.Text = row.Cells["trip_num"].Value.ToString();
                rate.Text = row.Cells["rate"].Value.ToString();
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string insert_feedback = @"insert into feedback (traveller_id,Number_trip,review_trip,rate_trip) values(@straveller_id,@sNumber_trip,@sreview_trip,@srate_trip)";
            SqlCommand cmd = new SqlCommand(insert_feedback, con);
            SqlParameter paramtravellerid = new SqlParameter("@straveller_id", traveller_id);
            cmd.Parameters.Add(paramtravellerid);
            SqlParameter paramName_hotel = new SqlParameter("@sNumber_trip", name.Text);
            cmd.Parameters.Add(paramName_hotel);
            SqlParameter paramreview_hotel = new SqlParameter("@sreview_trip", textBox2.Text);
            cmd.Parameters.Add(paramreview_hotel);
            SqlParameter paramrate_hotel = new SqlParameter("@srate_trip", textBox1.Text);
            cmd.Parameters.Add(paramrate_hotel);
            cmd.ExecuteNonQuery();
            string insert_profile = @"insert into Profile (id_traveller,trip_number) values(@straveller_id,@sNumber_trip)";
            SqlCommand cmd2 = new SqlCommand(insert_profile, con);
            SqlParameter paramtraveller = new SqlParameter("@straveller_id", traveller_id);
            cmd2.Parameters.Add(paramtraveller);
            SqlParameter paramName_ho = new SqlParameter("@sNumber_trip", name.Text);
            cmd2.Parameters.Add(paramName_ho);



            cmd2.ExecuteNonQuery();
            MessageBox.Show("You reserved a trip program ");
            con.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            dataGridView1.DataSource = tbl;
            name.Text = "";
            rate.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            this.Hide();
        }
    }
}
