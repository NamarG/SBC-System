using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sphere_Booking_and_Check_in_System.Session_Managment
{
    public partial class frmUpdate : Form
    {
        public frmUpdate()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to save this record?", "Save Record", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    try
                    {
                        Connection.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE Session SET staffID=@staff, slopeID=@slope, startTime=@start, endTime=@end, date=@d WHERE Id = '" + txtSearchBox.Text + "'", Connection);
                        cmd.Parameters.AddWithValue("@staff", txtStaffID.Text);
                        cmd.Parameters.AddWithValue("@slope", comboBoxSlope.Text);
                        cmd.Parameters.AddWithValue("@start", txtStartTime.Text);
                        cmd.Parameters.AddWithValue("@end", txtEndTime.Text);
                        cmd.Parameters.AddWithValue("@d", dateTimePicker1.Text);

                        cmd.ExecuteNonQuery();
                        int i = cmd.ExecuteNonQuery();

                        if (i > 0)
                        {
                            MessageBox.Show("Record Saved");
                            txtSearchBox.Clear();
                            txtSessionID.Text = "";
                            comboBoxSlope.Text = "Select Slope....";
                            txtStaffID.Text = "";
                            txtStartTime.Text = "";
                            txtEndTime.Text = "";
                            dateTimePicker1.Text = "";

                            comboBoxSlope.Enabled = false;
                            txtStaffID.Enabled = false;
                            txtStartTime.Enabled = false;
                            txtEndTime.Enabled = false;
                            dateTimePicker1.Enabled = false;
                            dateTimePicker1.Enabled = false;
                            comboBoxSlope.Enabled = false;

                            btnSave.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Unexpected error, record was not deleted");
                            Connection.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unexpected error:" + ex.Message);
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                if (txtSearchBox.Text == String.Empty)
                {
                    MessageBox.Show("Search Critera is Empty");
                    txtSearchBox.Focus();
                }
                else
                {
                    try
                    {
                        Connection.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM Session WHERE (Id = '" + txtSearchBox.Text + "')", Connection);
                        SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM Session WHERE (Id = '" + txtSearchBox.Text + "')", Connection);
                        int result = (int)cmdCheck.ExecuteScalar();

                        if (result > 0)
                        {
                            MessageBox.Show("Record Found!");
                            SqlDataReader sdr = cmd.ExecuteReader();

                            while (sdr.Read())
                            {
                                txtSessionID.Text = (sdr["Id"].ToString());
                                comboBoxSlope.Text = (sdr["slopeID"].ToString());
                                txtStaffID.Text = (sdr["staffID"].ToString());
                                txtStartTime.Text = (sdr["startTime"].ToString());
                                txtEndTime.Text = (sdr["endTime"].ToString());
                                dateTimePicker1.Text = (sdr["date"].ToString());

                                comboBoxSlope.Enabled = true;
                                txtStaffID.Enabled = true;
                                txtStartTime.Enabled = true;
                                txtEndTime.Enabled = true;
                                dateTimePicker1.Enabled = true;
                                dateTimePicker1.Enabled = true;
                                comboBoxSlope.Enabled = true;
                            }
                            Connection.Close();
                            btnSave.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("No Record Exists");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unexpected error:" + ex.Message);
                    }
                }
            }
        }
    }
}
