using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sphere_Booking_and_Check_in_System.Session_Managment
{
    public partial class frmRecoveryCodeManager : Form
    {
        public frmRecoveryCodeManager()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                if (txtCode.Text == String.Empty)
                {
                    MessageBox.Show("Please enter your unique email code", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCode.Focus();
                }

                else
                {
                    try
                    {
                        Connection.Open();
                        SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM Manager WHERE uniuqeEmailCode=@code", Connection);
                        cmd.Parameters.AddWithValue("@code", txtCode.Text);
                        int result = (int)cmd.ExecuteScalar();

                        if (result > 0)
                        {
                            SqlCommand commandPass = new SqlCommand("SELECT Password, UniuqeEmailCode FROM Manager WHERE uniuqeEmailCode = '" + txtCode.Text + "'", Connection);

                            string password = ((string)commandPass.ExecuteScalar());
                            MessageBox.Show("Your password is: " + password, "Password Recovered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Connection.Close();
                        }

                        else
                        {
                            MessageBox.Show("Code is incorrect, try again");
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Unexpected error:" + ex.Message);
                        Connection.Close();
                    }
                }
            }
        }
    }
}
