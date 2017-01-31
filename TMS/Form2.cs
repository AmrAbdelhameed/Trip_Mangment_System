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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-OEMOTGQ;Integrated Security=SSPI;Initial Catalog=TMS");
        SqlConnection con2 = new SqlConnection("Data Source=DESKTOP-OEMOTGQ;Integrated Security=SSPI;Initial Catalog=TMS");
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int c = 0;
            if (!(textBox3.Text=="") && !(textBox4.Text == ""))
            {
                char [] array = textBox4.Text.ToCharArray();
                for (int i = 0; i < array.Length; i++)
                {
                    char letter = array[i];
                    if (letter == '!' || letter == ',' || letter == '@' || letter == '#' ||
                        letter == '$' || letter == '&' || letter == '^' || letter == '%' ||
                        letter == '*' || letter == '(' || letter == ')' || letter == '.' )
                    {
                        c++;
                    }
                }
                if (c==0)
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("select * from traveller where username = '" + textBox3.Text + "'", con);
                        SqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        int count = 0;
                        while (dr.Read())
                        {
                            count += 1;
                        }
                        if (count >= 1)
                        {
                            MessageBox.Show("Already username is taken");
                            count = 0;
                        }
                        else
                        {
                            con2.Open();
                            string insertStr = @"insert into traveller(firstname, lastname, phone, nationality, username, password, age)
                                 values(@nfirstname, @nlastname, @nphone, @nnationality, @nusername, @npassword, @nage)";
                            SqlCommand cmd2 = new SqlCommand(insertStr, con2);
                            SqlParameter paramFirstName = new SqlParameter("@nfirstname", textBox1.Text);
                            cmd2.Parameters.Add(paramFirstName);
                            SqlParameter paramLastName = new SqlParameter("@nlastname", textBox2.Text);
                            cmd2.Parameters.Add(paramLastName);
                            SqlParameter paramPhone = new SqlParameter("@nphone", textBox5.Text);
                            cmd2.Parameters.Add(paramPhone);
                            SqlParameter paramNationality = new SqlParameter("@nnationality", textBox6.Text);
                            cmd2.Parameters.Add(paramNationality);
                            SqlParameter paramAge = new SqlParameter("@nage", textBox7.Text);
                            cmd2.Parameters.Add(paramAge);
                            SqlParameter paramUsername = new SqlParameter("@nusername", textBox3.Text);
                            cmd2.Parameters.Add(paramUsername);
                            SqlParameter paramPassword = new SqlParameter("@npassword", textBox4.Text);
                            cmd2.Parameters.Add(paramPassword);
                            cmd2.ExecuteNonQuery();
                            MessageBox.Show("Registration Succefully :D");
                            con2.Close();

                            textBox1.Text = "";
                            textBox2.Text = "";
                            textBox3.Text = "";
                            textBox4.Text = "";
                            textBox5.Text = "";
                            textBox6.Text = "";
                            textBox7.Text = "";
                            Form1 frm = new Form1();
                            frm.Show();
                            this.Hide();
                        }
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
                        con.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                    else
                    {
                    label2.ForeColor = Color.Red;
                    c = 0;
                    }
               
                 
                
            }
            else if ((textBox3.Text == "") && (textBox4.Text == ""))
            {
                MessageBox.Show("Forget Enter Username & Password ... Please Try Again");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Forget Enter Username ... Please Try Again");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Forget Enter Password ... Please Try Again");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Close();
            Application.Exit();
        }

        

        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.PasswordChar = '*';
            textBox4.MaxLength = 14;
            textBox4.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
