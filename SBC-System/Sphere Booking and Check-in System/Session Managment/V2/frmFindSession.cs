using System;
using System.Data.SqlClient;
using DevComponents.DotNetBar;
using DevComponents.Schedule.Model;
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

            calendarView1.CalendarModel = new CalendarModel();
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

        private void btnApply_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();

            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                if (dateTimePicker1.Text == String.Empty)
                {
                    MessageBoxEx.Show("Please enter the date", "Input Error");
                    dateTimePicker1.Focus();
                }
                else
                {
                    try
                    {
                        Connection.Open();
                        SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM Session WHERE date=@d", Connection);
                        cmd.Parameters.AddWithValue("@d", dateTimePicker1.Text);
                        int result = (int)cmd.ExecuteScalar();

                        if (result > 0)
                        {
                            using (cmd = new SqlCommand("SELECT date FROM Session WHERE date=@d", Connection))
                                cmd.Parameters.AddWithValue("@d", dateTimePicker1.Text);
                            {
                                SqlDataReader sdr = cmd.ExecuteReader();

                                while (sdr.Read())
                                {
                                    calendarView1.ShowDate(Convert.ToDateTime(sdr["date"]));
                                }
                            }
                            groupBox1.Enabled = true;
                            Connection.Close();
                        }
                        else
                        {
                            MessageBoxEx.Show("Session doesn't exist");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBoxEx.Show("Unexpected error:" + ex.Message);
                    }
                }
            }
        }

        private Appointment AddAppointment(string title, int slope, int limit, DateTime startTime, DateTime endTime, string color)
        {
            bool limitReached;

            if(limit == 30)
            {
                limitReached = true;
            }
            else
            {
                limitReached = false;
            }

            Appointment appointment = new Appointment();

            appointment.StartTime = startTime;
            appointment.EndTime = endTime;

            appointment.Subject = title;
            appointment.Description = "On slope: " + slope + '\n' + "Limited Reached? " + limitReached;
            appointment.CategoryColor = color;

            calendarView1.CalendarModel.Appointments.Add(appointment);
            return (appointment);
            
        }

        private void frmFindSession_Load(object sender, EventArgs e)
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM Session", Connection);
                    int result = (int)cmd.ExecuteScalar();

                    if (result > 0)
                    {
                        using (cmd = new SqlCommand("SELECT Id, slopeID, date, startTime, endTime, limit FROM Session", Connection))
                        {
                            SqlDataReader sdr = cmd.ExecuteReader();

                            while (sdr.Read())
                            {
                                DateTime date = Convert.ToDateTime(sdr["date"].ToString());

                                int slope = (int)sdr["slopeID"];
                                int sessionId = int.Parse(sdr["Id"].ToString());
                                int limit = int.Parse(sdr["limit"].ToString());
                                TimeSpan startTime = (TimeSpan)sdr["startTime"];
                                int st = int.Parse(startTime.Hours.ToString());
                                TimeSpan endTime = (TimeSpan)sdr["endTime"];
                                int et = int.Parse(endTime.Hours.ToString());

                                AddAppointment("Session: " + sessionId, slope, limit, date.AddHours(st), date.AddHours(et), Appointment.CategoryBlue);
                            }
                            sdr.Close();
                        }
                        Connection.Close();
                    }
                    else
                    {
                        MessageBoxEx.Show("Session doesn't exist");
                    }
                }
                catch (Exception ex)
                {
                    MessageBoxEx.Show("Unexpected error:" + ex.Message);
                }
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            btnApply.Enabled = false;
            
        }
    }
}
