using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sphere_Booking_and_Check_in_System.Session_Managment
{
    public partial class frmAddNew : Form
    {
        public frmAddNew()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                if (txtKey.Text == String.Empty || txtStaffID.Text == String.Empty ||
                    txtStartTime.Text == String.Empty || comboBoxSlope.Text == String.Empty)
                {
                    MessageBox.Show("Error, values missing", "Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        Connection.Open();
                        SqlCommand cmd = new SqlCommand(@"INSERT INTO Session ([staffID], [slopeID], [startTime], [endTime], [date]) VALUES (@staffID, @slopeID, @startTime, @endTime, @date);", Connection);
                        cmd.Parameters.AddWithValue("@slopeID", comboBoxSlope.Text);
                        cmd.Parameters.AddWithValue("@staffID", txtStaffID.Text);
                        cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@startTime", txtStartTime.Text.ToString());
                        cmd.Parameters.AddWithValue("@endTime", txtEndTime.Text.ToString());

                        int i = cmd.ExecuteNonQuery();
                        Connection.Close();

                        if(i == 1)
                        {
                            MessageBox.Show("Session has been added");
                            getPrimaryKey();

                            txtEndTime.Clear();
                            txtKey.Clear();
                            txtStaffID.Clear();
                            txtStartTime.Clear();
                            comboBoxSlope.Text = "Select Slope....";
                        }
                        else
                        {
                            MessageBox.Show("Session couldn't be added at this time");
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Unexpected error:" + ex.Message);
                    }
                }
            }
        }

        private void getPrimaryKey()
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT MAX(Id)+1 FROM Session;", Connection);
                    txtKey.Text = cmd.ExecuteScalar().ToString();
                    Connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error:" + ex.Message);
                }
            }
        }

        private void frmAddNew_Load(object sender, EventArgs e)
        {
            getPrimaryKey();
        }
    }
}
