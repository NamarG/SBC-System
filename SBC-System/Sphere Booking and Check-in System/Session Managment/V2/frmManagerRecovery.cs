using System;
using System.Data.SqlClient;
using DevComponents.DotNetBar;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Sphere_Booking_and_Check_in_System.Session_Managment.V2
{
    public partial class frmManagerRecovery : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmManagerRecovery()
        {
            InitializeComponent();

            this.txtEmail.KeyPress += new KeyPressEventHandler(CheckEnter);
        }

        private void CheckEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSubmit_Click(this, new EventArgs());
            }
        }

        public static bool IsValidEmailAddress(string emailaddress) //REFERENCE: http://stackoverflow.com/questions/36035941/check-valid-email-address-in-c-sharp
        {
            try
            {
                Regex rx = new Regex(@"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$");
                return rx.IsMatch(emailaddress);
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                if (txtEmail.Text == String.Empty)
                {
                    MessageBoxEx.Show("Please enter your email address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtEmail.Focus();
                }
                else if (!IsValidEmailAddress(txtEmail.Text))
                {
                    MessageBoxEx.Show("Invalid Email Address", "Invalid Email Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        Connection.Open();
                        SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM Manager WHERE email=@emailAddress", Connection);
                        cmd.Parameters.AddWithValue("@emailAddress", txtEmail.Text);
                        int result = (int)cmd.ExecuteScalar();

                        if (result > 0)
                        {
                            Connection.Close();

                            //Show verifcation screen
                            Session_Managment.V2.frmManagerRecoveryCode code = new frmManagerRecoveryCode();
                            code.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBoxEx.Show("Email does not exist in this system");
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBoxEx.Show("Unexpected error:" + ex.Message);
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}