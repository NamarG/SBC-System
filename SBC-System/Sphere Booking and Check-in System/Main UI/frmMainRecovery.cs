using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sphere_Booking_and_Check_in_System.Main_UI
{
    public partial class frmMainRecovery : Form
    {
        public frmMainRecovery()
        {
            InitializeComponent();

            //Enter key pressed
            this.txtEmail.KeyPress += new KeyPressEventHandler(CheckEnter);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                if (txtEmail.Text == String.Empty)
                {
                    MessageBox.Show("Please enter your email address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtEmail.Focus();
                }

                else
                {
                    try
                    {
                        Connection.Open();
                        SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM Staff WHERE emailAddress=@emailAddress", Connection);
                        cmd.Parameters.AddWithValue("@emailAddress", txtEmail.Text);
                        int result = (int)cmd.ExecuteScalar();

                        if (result > 0)
                        {
                            Connection.Close();
                            Main_UI.frmMainRecoveryCode verify = new Main_UI.frmMainRecoveryCode();
                            verify.Show();
                        }
                        else
                        {
                            MessageBox.Show("Email does not exist in this system");
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Unexpected error:" + ex.Message);
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_UI.frmMainLogin login = new Main_UI.frmMainLogin();
            login.Show();
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
