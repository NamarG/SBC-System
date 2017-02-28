using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Sphere_Booking_and_Check_in_System.Staff_Scheduling
{
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Staff_Scheduling", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet ds = new DataSet())
                        {
                            sda.Fill(ds);
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                    }
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                if (txtStaffID.Text == String.Empty || txtStartTime.Text == String.Empty || txtEndTime.Text == String.Empty)
                {
                    MessageBox.Show("Error, values missing", "Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        Connection.Open();
                        SqlCommand cmd = new SqlCommand(@"INSERT INTO Staff_Scheduling ([staffID], [date], [startTime], [endTime], [booked]) VALUES (@staffID, @date, @startTime, @endTime, 0);", Connection);
                        cmd.Parameters.AddWithValue("@staffID", txtStaffID.Text);
                        cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@startTime", txtStartTime.Text.ToString());
                        cmd.Parameters.AddWithValue("@endTime", txtEndTime.Text.ToString());

                        int i = cmd.ExecuteNonQuery();
                        Connection.Close();

                        if (i == 1)
                        {
                            MessageBox.Show("Staff has been scheduled");

                            using (cmd = new SqlCommand("SELECT * FROM Staff_Scheduling", Connection))
                            {
                                cmd.CommandType = CommandType.Text;
                                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                                {
                                    using (DataSet ds = new DataSet())
                                    {
                                        sda.Fill(ds);
                                        dataGridView1.DataSource = ds.Tables[0];
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Staff couldn't be added at this time");
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Unexpected error:" + ex.Message);
                    }
                }
            }
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDatabaseDataSet.Staff_Scheduling' table. You can move, or remove it, as needed.
            this.staff_SchedulingTableAdapter.Fill(this.mainDatabaseDataSet.Staff_Scheduling);
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Staff_Scheduling", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet ds = new DataSet())
                        {
                            sda.Fill(ds);
                            dataGridView1.DataSource = ds.Tables[0];
                        }
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
