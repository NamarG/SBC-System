using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sphere_Booking_and_Check_in_System.Session_Managment
{
    public partial class frmDelete : Form
    {
        public frmDelete()
        {
            InitializeComponent();
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

                        if(result > 0)
                        {
                            MessageBox.Show("Record Found!");
                            SqlDataReader sdr = cmd.ExecuteReader();

                            while (sdr.Read())
                            {
                                lblSessionID.Text = (sdr["Id"].ToString());
                                lblSlopeID.Text = (sdr["slopeID"].ToString());
                                lblStaffID.Text = (sdr["staffID"].ToString());
                                lblCustomerID.Text = (sdr["customerID"].ToString());
                                lblStartTime.Text = (sdr["startTime"].ToString());
                                lblEndTime.Text = (sdr["endTime"].ToString());
                                lblDate.Text = Convert.ToDateTime(sdr["date"]).ToString("dd/mm/yyyy");
                            }

                            Connection.Close();
                            btnDelete.Enabled = true;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Record Deletion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    try
                    {
                        Connection.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Session WHERE Id = '" + lblSessionID.Text + "'", Connection);
                        int i = cmd.ExecuteNonQuery();

                        if(i > 0)
                        {
                            MessageBox.Show("Record Deleted");
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
    }
}
