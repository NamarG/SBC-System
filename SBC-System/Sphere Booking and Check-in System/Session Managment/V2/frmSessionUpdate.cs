using System;
using DevComponents.DotNetBar;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sphere_Booking_and_Check_in_System.Session_Managment.V2
{
    public partial class frmSessionUpdate : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmSessionUpdate()
        {
            InitializeComponent();
        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            Session_Managment.V2.frmFindSession findSession = new Session_Managment.V2.frmFindSession();
            findSession.Show();
            findSession.SetDesktopLocation(this.Location.X + this.Size.Width, this.Location.Y);
            findSession.Owner = this;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled = true;
        }

        private void btnFindStaff_Click(object sender, EventArgs e)
        {
            Session_Managment.V2.frmFindStaff frmFindStaff = new Session_Managment.V2.frmFindStaff();
            frmFindStaff.Show();
            frmFindStaff.SetDesktopLocation(this.Location.X + this.Size.Width, this.Location.Y);
            frmFindStaff.Owner = this;
        }

        private void frmSessionUpdate_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            Properties.Settings.Default.staffID = 0;
        }

        private void txtStaffID_Click(object sender, System.EventArgs e)
        {
            if (Properties.Settings.Default.staffID > 0)
            {
                txtStaffID.Text = Properties.Settings.Default.staffID.ToString();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtStaffID.Text == String.Empty || comboBoxEx1.Text == String.Empty || comboBoxEx2.Text == String.Empty || dateTimePicker1.Text == String.Empty || comboBoxSlope.Text == String.Empty)
            {
                MessageBoxEx.Show("Error, missing details");
            }
            else
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
                            cmd.Parameters.AddWithValue("@start", comboBoxEx1.Text);
                            cmd.Parameters.AddWithValue("@end", comboBoxEx2.Text);
                            cmd.Parameters.AddWithValue("@d", dateTimePicker1.Text);

                            cmd.ExecuteNonQuery();
                            int i = cmd.ExecuteNonQuery();
                            cmd = new SqlCommand("UPDATE Staff_Scheduling SET booked=1 WHERE date=@d", Connection);
                            cmd.Parameters.AddWithValue("@d", dateTimePicker1.Text);
                            int j = cmd.ExecuteNonQuery();

                            if (i > 0 && j > 0)
                            {
                                MessageBox.Show("Record Saved");
                                txtSearchBox.Clear();
                                comboBoxSlope.Text = "Select Slope....";
                                txtStaffID.Text = "";
                                comboBoxEx1.Text = "";
                                comboBoxEx2.Text = "";
                                dateTimePicker1.Text = "";

                                comboBoxSlope.Enabled = false;
                                txtStaffID.Enabled = false;
                                comboBoxEx1.Enabled = false;
                                comboBoxEx2.Enabled = false;
                                dateTimePicker1.Enabled = false;
                                comboBoxSlope.Enabled = false;

                                btnSubmit.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("Unexpected error, record was not updated");
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
}