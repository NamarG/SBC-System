using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sphere_Booking_and_Check_in_System.Check_in
{
    public partial class CheckIn : Form
    {
        public CheckIn()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Customer WHERE (Id = '" + textBox1.Text + "')", connection);

                try
                {
                    int i = (int)command.ExecuteScalar();
                    if (i > 0)
                    {
                        int id = int.Parse(textBox1.Text);
                        Check_in.CheckInDetails details = new CheckInDetails(id);
                        details.MdiParent = this.ParentForm;
                        details.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error, customer doesn't exist");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error:" + ex.Message);
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help checkin = new Check_in.Help();
            checkin.MdiParent = this.ParentForm;
            checkin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Navigation to the Home page, from the check in page.
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ForgotId checkin = new ForgotId();
            checkin.MdiParent = this.ParentForm;
            checkin.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckIn_Load(object sender, EventArgs e)
        {

        }
    }
}
