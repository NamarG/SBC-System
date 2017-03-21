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
using System.Text.RegularExpressions;

namespace Sphere_Booking_and_Check_in_System.Check_in
{
    public partial class ForgotId : Form
    {
        public ForgotId()
        {
            InitializeComponent();
        }

        private void ForgotId_Load(object sender, EventArgs e)
        {

        }

        public static bool isValidEmail(string inputEmail)  //http://stackoverflow.com/questions/16167983/best-regular-expression-for-email-validation-in-c-sharp
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Customer WHERE (emailAddress = '" + textBox1.Text + "')", connection);
                try
                {
                    if(isValidEmail(textBox1.Text) == true)
                    {
                        int i = (int)command.ExecuteScalar();
                        if (i > 0)
                        {
                            try
                            {
                                command = new SqlCommand("SELECT Id FROM Customer WHERE (emailAddress = '" + textBox1.Text + "')", connection);
                                int id = ((int)command.ExecuteScalar());
                                Check_in.CheckInDetails details = new CheckInDetails(id);
                                details.MdiParent = this.ParentForm;
                                details.Show();
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Unexpected error:" + ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error, e-mail doesn't exist");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid email entered");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error:" + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}