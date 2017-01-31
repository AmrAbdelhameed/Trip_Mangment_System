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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-OEMOTGQ;Integrated Security=SSPI;Initial Catalog=TMS");
        public string user,hotelname;
        public int bil;
        public int _id;
        public Form3()
        {
            InitializeComponent();
            
        }
        
       
        Bunifu.Framework.UI.Drag dr = new Bunifu.Framework.UI.Drag();
        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            dr.Grab(this);
        }

        private void header_MouseUp(object sender, MouseEventArgs e)
        {
            dr.Release();
        }

        private void header_MouseMove(object sender, MouseEventArgs e)
        {
            dr.MoveObject();
        }

        private void lbltab1_Click(object sender, EventArgs e)
        {
            line.Width = lbltab1.Width;
            line.Left = lbltab1.Left;
            tab21.Visible = true;
            tab21.BringToFront();
        }

        private void lbltab2_Click(object sender, EventArgs e)
        {
            line.Width = lbltab2.Width;
            line.Left = lbltab2.Left;
            tab31.Visible = true;
            tab31.BringToFront();
        }

        private void lbltab3_Click(object sender, EventArgs e)
        {
            line.Width = lbltab3.Width;
            line.Left = lbltab3.Left;
            tab41.Visible = true;
            tab41.BringToFront();
        }
        
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

       

        private void ho_name_Click(object sender, EventArgs e)
        {
            ho_name.Text = hotelname;
        }

    

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.name = lbl1.Text;
            f.nat = lbl3.Text;
            f.phone = lbl4.Text;
            f.bill2 = bunifuCustomLabel1.Text;
            f.hot_name = ho_name.Text;
            f.trip_num = tr_number.Text;
            f.user_name = lbl2.Text;
            f.user12 = user;
            f.Show();
            this.Hide();

        }

        private void bunifuCustomLabel1_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select bill from Profile where id_traveller=@sid ", con);
                SqlParameter prsid = new SqlParameter("@sid", _id);
                cmd.Parameters.Add(prsid);
                bunifuCustomLabel1.Text = cmd.ExecuteScalar().ToString();
                con.Close();
            }
            catch
            {
                MessageBox.Show("You don't have Trip .. Go to Book Trip");
            }
            finally
            {
                con.Close();
            }
        }

        private void ho_name_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select hotel_name from Profile where id_traveller=@sid ", con);
                SqlParameter prsid = new SqlParameter("@sid", _id);
                cmd.Parameters.Add(prsid);
                ho_name.Text = cmd.ExecuteScalar().ToString();
                con.Close();
            }
            catch
            {
                MessageBox.Show("You don't have Trip .. Go to Book Trip");
            }

        }

        private void tab21_Load(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
            
            con.Open();
            SqlCommand cmd = new SqlCommand("select firstname from traveller where username=@username ", con);
            SqlParameter pramname = new SqlParameter("@username", user);
            cmd.Parameters.Add(pramname);
            lbl1.Text = cmd.ExecuteScalar().ToString();
            lbl1.Text += " ";
           SqlCommand cmdd = new SqlCommand("select lastname from traveller where username=@username ", con);
            SqlParameter pramnam = new SqlParameter("@username", user);
            cmdd.Parameters.Add(pramnam);
            lbl1.Text += cmdd.ExecuteScalar().ToString();

            lbl2.Text = "Username : " + user;

            SqlCommand cmd3 = new SqlCommand("select nationality from traveller where username=@username ", con);
            SqlParameter pramnationality = new SqlParameter("@username", user);
            cmd3.Parameters.Add(pramnationality);
            lbl3.Text = cmd3.ExecuteScalar().ToString();

            SqlCommand cmd4 = new SqlCommand("select phone from traveller where username=@username ", con);
            SqlParameter pramphone = new SqlParameter("@username", user);
            cmd4.Parameters.Add(pramphone);
            lbl4.Text = cmd4.ExecuteScalar().ToString();

            SqlCommand cmd5 = new SqlCommand("select id from traveller where username=@username ", con);
            SqlParameter pramid = new SqlParameter("@username", user);
            cmd5.Parameters.Add(pramid);
             _id = (int)cmd5.ExecuteScalar();

            
            tab21.id_trav = _id;
            tab41.id_trav = _id;
            con.Close();
        }
    }
}
