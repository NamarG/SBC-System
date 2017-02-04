using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sphere_Booking_and_Check_in_System.Session_Managment
{
    public partial class frmRecoveryManager : Form
    {
        public frmRecoveryManager()
        {
            InitializeComponent();

            //Event handler for X button
            this.FormClosing += new FormClosingEventHandler(frmRecoveryManager_FormClosing);

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
                        SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM Manager WHERE email=@emailAddress", Connection);
                        cmd.Parameters.AddWithValue("@emailAddress", txtEmail.Text);
                        int result = (int)cmd.ExecuteScalar();

                        if (result > 0)
                        {
                            Connection.Close();

                            //Show verifcation screen
                            frmRecoveryCodeManager verify = new frmRecoveryCodeManager();
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

        private void CheckEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSubmit_Click(this, new EventArgs());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManagerLogin login = new frmManagerLogin();
            login.Show();
        }

        private void frmRecoveryManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmManagerLogin login = new frmManagerLogin();
            login.Show();
        }
    }
}
