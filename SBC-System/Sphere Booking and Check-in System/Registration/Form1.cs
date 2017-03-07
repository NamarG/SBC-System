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

namespace Sphere_Booking_and_Check_in_System.Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {

                if (textBox1.Text == String.Empty || textBox2.Text == String.Empty || textBox3.Text == String.Empty || textBox4.Text == String.Empty || textBox5.Text == String.Empty)
                {
                    MessageBox.Show("Error, values missing", "Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
               {
                    try
                    {
                        Connection.Open();
                         SqlCommand cmd = new SqlCommand(@"INSERT INTO Customer ([firstname], [lastname], [membership], [emailAddress], [phoneNumber], [address]) VALUES (@firstname, @lastname, @membership, @emailAddress, @phoneNumber, @address);", Connection);
                        cmd.Parameters.AddWithValue("@firstname", textBox1.Text);
                        cmd.Parameters.AddWithValue("@lastname", textBox2.Text);
                        cmd.Parameters.AddWithValue("@membership", checkBox1.Checked);
                        cmd.Parameters.AddWithValue("@emailAddress", textBox3.Text);
                        cmd.Parameters.AddWithValue("@phoneNumber", textBox4.Text);
                        cmd.Parameters.AddWithValue("@address", textBox5.Text);

                        int i = cmd.ExecuteNonQuery();
                        Connection.Close();

                        if (i == 1)
                        {
                            MessageBox.Show("customer has been added");
                            getPrimaryKey();
                      
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                            textBox5.Clear();
                        }
                    else
                        {
                            MessageBox.Show("customer couldn't be added at this time");
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Unexpected error:" + ex.Message);
                    }
                }
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }


        private void getPrimaryKey()
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT MAX(Id)+1 FROM Customer;", Connection);     
                    Connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error:" + ex.Message);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
