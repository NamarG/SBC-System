using System;
using System.Data.SqlClient;
using DevComponents.DotNetBar;
using System.Drawing;
using System.Data;

namespace Sphere_Booking_and_Check_in_System.Session_Managment.V2
{
    public partial class frmFindSession : DevComponents.DotNetBar.Metro.MetroForm
    {
        private Point oldLocation = new Point(int.MaxValue, 0);

        public frmFindSession()
        {
            InitializeComponent();
        }

        protected override void OnLocationChanged(EventArgs e)
        {
            if (oldLocation.X != int.MaxValue && this.Owner != null)
            {
                this.Owner.Location = new Point(
                    this.Owner.Left + this.Left - oldLocation.X,
                    this.Owner.Top + this.Top - oldLocation.Y);
            }
            oldLocation = this.Location;
            base.OnLocationChanged(e);
        }

        private void btnSearchSession_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                if (dateTimeInput1.Text == String.Empty)
                {
                    MessageBoxEx.Show("Please enter the first name", "Input Error");
                    dateTimeInput1.Focus();
                }
                else
                {
                    if (String.IsNullOrEmpty(maskedTextBoxAdv1.Text) || String.IsNullOrEmpty(maskedTextBoxAdv2.Text))
                    {
                        try
                        {
                            Connection.Open();
                            SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM Session WHERE date=@d", Connection);
                            cmd.Parameters.AddWithValue("@d", dateTimeInput1.Value.ToString("dd/mm/yyyy"));
                            int result = (int)cmd.ExecuteScalar();

                            if (result > 0)
                            {
                                Connection.Close();
                                using (cmd = new SqlCommand("SELECT Id, slopeID, date, startTime, endTime FROM Session WHERE date=@d", Connection))
                                {
                                    cmd.Parameters.AddWithValue("@d", dateTimeInput1.Value.ToString("dd/mm/yyyy"));

                                    cmd.CommandType = CommandType.Text;
                                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                                    {
                                        using (DataSet ds = new DataSet())
                                        {
                                            sda.Fill(ds);
                                            dataGridViewX1.DataSource = ds.Tables[0];
                                        }
                                    }
                                }
                                Properties.Settings.Default.sessionDate = dateTimeInput1.Value;
                            }
                            else
                            {
                                MessageBoxEx.Show("Not Session Exist");
                                //Clear rows
                            }
                        }

                        catch (Exception ex)
                        {
                            MessageBoxEx.Show("Unexpected error:" + ex.Message);
                            //Clear rows
                        }
                    }
                    else
                    {
                        try
                        {
                            Connection.Open();
                            SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM Session WHERE date=@d AND startTime=@start AND endTime=@end", Connection);
                            cmd.Parameters.AddWithValue("@d", dateTimeInput1.Value.ToLongDateString());
                            cmd.Parameters.AddWithValue("@start", maskedTextBoxAdv1.Text);
                            cmd.Parameters.AddWithValue("@end", maskedTextBoxAdv2.Text);
                            int result = (int)cmd.ExecuteScalar();

                            if (result > 0)
                            {
                                Connection.Close();
                                using (cmd = new SqlCommand("SELECT Id, slopeID, date, startTime, endTime FROM Session WHERE date=@d AND startTime=@start AND endTime=@end", Connection))
                                {
                                    cmd.Parameters.AddWithValue("@d", dateTimeInput1.Value.ToLongDateString());
                                    cmd.Parameters.AddWithValue("@start", maskedTextBoxAdv1.Text);
                                    cmd.Parameters.AddWithValue("@end", maskedTextBoxAdv2.Text);

                                    cmd.CommandType = CommandType.Text;
                                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                                    {
                                        using (DataSet ds = new DataSet())
                                        {
                                            sda.Fill(ds);
                                            dataGridViewX1.DataSource = ds.Tables[0];
                                        }
                                    }
                                }
                                Properties.Settings.Default.sessionDate = dateTimeInput1.Value;
                            }
                            else
                            {
                                MessageBoxEx.Show("Not Session Exist");
                                //Clear rows
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBoxEx.Show("Unexpected error:" + ex.Message);
                            //Clear rows
                        }
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFindSession_Load(object sender, EventArgs e)
        {
            dateTimeInput1.Value = DateTime.Now;
        }
    }
}