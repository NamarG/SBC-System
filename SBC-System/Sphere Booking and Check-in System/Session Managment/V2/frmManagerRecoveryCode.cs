using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Sphere_Booking_and_Check_in_System.Session_Managment.V2
{
    public partial class frmManagerRecoveryCode : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmManagerRecoveryCode()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                if (txtCode.Text == String.Empty)
                {
                    MessageBoxEx.Show("Please enter your unique email code", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCode.Focus();
                }

                else
                {
                    try
                    {
                        Connection.Open();
                        SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM Manager WHERE recoveryCode=@code", Connection);
                        cmd.Parameters.AddWithValue("@code", txtCode.Text);
                        int result = (int)cmd.ExecuteScalar();

                        if (result > 0)
                        {
                            SqlCommand commandPass = new SqlCommand("SELECT Password, recoveryCode FROM Manager WHERE recoveryCode = '" + txtCode.Text + "'", Connection);

                            string password = ((string)commandPass.ExecuteScalar());
                            MessageBoxEx.Show("Your password is: " + password, "Password Recovered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Connection.Close();
                        }

                        else
                        {
                            MessageBoxEx.Show("Code is incorrect, try again");
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBoxEx.Show("Unexpected error:" + ex.Message);
                        Connection.Close();
                    }
                }
            }
        }

        private void CheckEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSubmit_Click(this, new EventArgs());
            }
        }
    }
}