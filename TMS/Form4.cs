using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TMS
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-OEMOTGQ;Integrated Security=SSPI;Initial Catalog=TMS");
        public string name, nat, phone, user_name,hot_name, trip_num,bill2,user12;
        public int _id;
        private void delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd5 = new SqlCommand("select id from traveller where username=@username ", con);
            SqlParameter pramid = new SqlParameter("@username", user12);
            cmd5.Parameters.Add(pramid);
            _id = (int)cmd5.ExecuteScalar();
            
            string upstring1 = @"delete from Profile  where id_traveller=@varid";

            SqlCommand cmd1 = new SqlCommand(upstring1, con);
            SqlParameter idd = new SqlParameter("@varid", _id);
            cmd1.Parameters.Add(idd);
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" Deleted ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form3 f = new Form3();
            f.user = user12;
            f.Show();
            this.Hide();
        }

                

        private void update_Click(object sender, EventArgs e)
        {
            con.Open();
            

            if(!(textBox1.Text==""))
            {
                string upstring1 = @"update traveller set firstname=@varfirst where username=@varname";

                SqlCommand cmd1 = new SqlCommand(upstring1, con);

                SqlParameter firstname = new SqlParameter("@varfirst", textBox1.Text);
            cmd1.Parameters.Add(firstname);
                SqlParameter varname = new SqlParameter("@varname", user12);
                cmd1.Parameters.Add(varname);
                cmd1.ExecuteNonQuery();
            }
            if (!(textBox5.Text == ""))
            {
                string upstring2 = @"update traveller set lastname=@varlast where username=@varname";

                SqlCommand cmd2 = new SqlCommand(upstring2, con);

                SqlParameter lastname = new SqlParameter("@varlast", textBox5.Text);
                cmd2.Parameters.Add(lastname);
                SqlParameter varname = new SqlParameter("@varname", user12);
                cmd2.Parameters.Add(varname);
                cmd2.ExecuteNonQuery();
            }
                if (!(textBox3.Text == ""))
                {
                string upstring3 = @"update traveller set phone=@intph where username=@varname";

                SqlCommand cmd3 = new SqlCommand(upstring3, con);

                SqlParameter phone = new SqlParameter("@intph", textBox3.Text);
                    cmd3.Parameters.Add(phone);
                SqlParameter varname = new SqlParameter("@varname", user12);
                cmd3.Parameters.Add(varname);
                cmd3.ExecuteNonQuery();
            }
                    if (!(textBox2.Text == ""))
                    {
                string upstring4 = @"update traveller set nationality=@varnat where username=@varname";

                SqlCommand cmd4 = new SqlCommand(upstring4, con);

                SqlParameter nationality = new SqlParameter("@varnat", textBox2.Text);
                        cmd4.Parameters.Add(nationality);
                SqlParameter varname = new SqlParameter("@varname", user12);
                cmd4.Parameters.Add(varname);
                cmd4.ExecuteNonQuery();
            }

                        if (!(textBox4.Text == ""))
                        {
                string upstring5 = @"update traveller set password=@intpass where username=@varname";

                SqlCommand cmd5 = new SqlCommand(upstring5, con);

                SqlParameter password = new SqlParameter("@intpass", textBox4.Text);
                            cmd5.Parameters.Add(password);
                SqlParameter varname = new SqlParameter("@varname", user12);
                cmd5.Parameters.Add(varname);
                cmd5.ExecuteNonQuery();
            }
                           
                                
                            
            con.Close();
            MessageBox.Show(" Updated ");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            lbl1.Text = name;
            lbl2.Text = user_name;
            lbl3.Text = nat;
            lbl4.Text = phone;
            ho_name.Text = hot_name;
            tr_number.Text = trip_num;
            bunifuCustomLabel1.Text = bill2;

        }

        public Form4()
        {
            InitializeComponent();
        }
    }
}
