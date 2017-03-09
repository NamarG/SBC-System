using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Sphere_Booking_and_Check_in_System.Session_Managment.V2
{
    public partial class frmManagerLogin : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmManagerLogin()
        {
            InitializeComponent();

            txtUsername.KeyPress += new KeyPressEventHandler(CheckEnter);
            txtPassword.KeyPress += new KeyPressEventHandler(CheckEnter);
        }

        private void CheckEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                if (txtUsername.Text == String.Empty)
                {
                    MessageBoxEx.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsername.Focus();
                }

                else if (txtPassword.Text == String.Empty)
                {
                    MessageBoxEx.Show("Please enter password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPassword.Focus();
                }

                else
                {
                    try
                    {
                        Connection.Open();
                        SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM Manager WHERE username=@uname and password=@pass", Connection);
                        cmd.Parameters.AddWithValue("@uname", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                        int result = (int)cmd.ExecuteScalar();

                        if (result > 0)
                        {
                            Session_Managment.V2.frmManagerMain main = new frmManagerMain();
                            main.Show();
                            this.Hide();

                            Properties.Settings.Default.Manager = txtUsername.Text;

                            Connection.Close();
                        }
                        else
                        {
                            MessageBoxEx.Show("Incorrect login, please try again");
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBoxEx.Show("Unexpected error:" + ex.Message);
                    }
                }
            }
        }

        private void btnRecovery_Click(object sender, EventArgs e)
        {
            Session_Managment.V2.frmManagerRecovery recovery = new frmManagerRecovery();
            recovery.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}