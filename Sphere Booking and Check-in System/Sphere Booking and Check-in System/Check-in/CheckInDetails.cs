using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sphere_Booking_and_Check_in_System.Check_in
{
    public partial class CheckInDetails : Form
    {
        int id;
        public CheckInDetails(int customerID)
        {
            InitializeComponent();
            id = customerID;
        }

        private void CheckInDetails_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Customer WHERE Id = @customer", connection);
                command.Parameters.AddWithValue("customer", id);

                SqlDataReader sdr = command.ExecuteReader();

                while (sdr.Read())
                {
                    textBox1.Text = (sdr["Id"].ToString());
                    textBox2.Text = (sdr["firstName"].ToString());
                    textBox3.Text = (sdr["lastName"].ToString());
                    textBox7.Text = (sdr["emailAddress"].ToString());
                    textBox6.Text = (sdr["phoneNumber"].ToString());
                    textBox5.Text = (sdr["address"].ToString());
                    int memeber = sdr.GetOrdinal("Membership");
                    bool? active = sdr.IsDBNull(memeber) ? (bool?)null : sdr.GetBoolean(memeber);

                    if(active == true)
                    {
                        checkBox2.Checked = true;
                    }

                    checkBox1.Checked = true;
                }

                sdr.Close();

                command = new SqlCommand("SELECT Id FROM Booking WHERE customerID = @customer", connection);
                command.Parameters.AddWithValue("customer", id);
                sdr = command.ExecuteReader();

                while (sdr.Read())
                {
                    textBox8.Text = (sdr["Id"].ToString());
                }
                sdr.Close();
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckIn checkin = new Check_in.CheckIn();
            this.Close();
            checkin.Show();
        }
    }
}
