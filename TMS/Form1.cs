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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-OEMOTGQ;Integrated Security=SSPI;Initial Catalog=TMS");
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Select();
        }

        private void button1_Click_1(object sender, EventArgs e)
    {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from traveller where username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'", con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                count += 1;
            }
            if (count == 1)
            {
                MessageBox.Show("Login Successfully");
                Form3 frm = new Form3();
                frm.user=textBox1.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("username or Password Not Correct ..");
            }
            textBox1.Clear();
            textBox2.Clear();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 14;
            textBox2.Text = "";
        }
    }
}
