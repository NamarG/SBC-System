using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sphere_Booking_and_Check_in_System.Session_Managment.V2
{
    class Controller
    {
        private TextBox sessionID, staffID;
        private ComboBox Slope, StartTime, EndTime;
        private DateTimePicker date;
        private CheckBox b;

        public Controller(TextBox sesID, TextBox staID, ComboBox s, DateTimePicker d, ComboBox start, ComboBox end, CheckBox t)
        {
            sessionID = sesID;
            staffID = staID;
            Slope = s;
            date = d;
            StartTime = start;
            EndTime = end;
            b = t;
        }

        public Controller()
        {

        }

        public bool Update()
        {
            BookingType type = Factory.getType(b.Checked);
            bool getType = type.type(b.Checked);

            Session ses = new Session(int.Parse(sessionID.Text.ToString()), int.Parse(staffID.Text.ToString()), int.Parse(Slope.Text.ToString()), Convert.ToDateTime(date.Text), Convert.ToDateTime(StartTime.Text), Convert.ToDateTime(EndTime.Text), getType);
            bool i = ses.Update();
            return i;
        }

        public bool getSession()
        {
            Session session = new Session();
            bool i = session.getSession(int.Parse(sessionID.Text.ToString()));

            if (i)
            {
                staffID.Text = session.StaffID.ToString();
                Slope.Text = session.Slope.ToString();
                date.Text = session.Date.ToShortDateString();
                StartTime.Text = session.StartTime.ToShortTimeString();
                EndTime.Text = session.EndTime.ToShortTimeString();
                b.Checked = session.Group;
            }
            return i;
        }

        public bool Save()
        {
            BookingType type = Factory.getType(b.Checked);
            bool getType = type.type(b.Checked);

            Session ses = new Session(int.Parse(sessionID.Text.ToString()), int.Parse(staffID.Text.ToString()), int.Parse(Slope.Text.ToString()), Convert.ToDateTime(date.Text), Convert.ToDateTime(StartTime.Text), Convert.ToDateTime(EndTime.Text), getType);
            bool i = ses.Update();
            return i;
        }

        public bool manualTest()
        {
            Console.WriteLine("----------------BEGINING TEST----------------");
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Session SET staffID=2, slopeID=2, startTime=CAST('09:00' AS TIME), endTime=CAST('14:00' AS TIME), date=CAST('03-30-2017' AS DATETIME) WHERE Id=18", Connection);
                    int i = cmd.ExecuteNonQuery();

                    if (i > 0)
                    {
                        Console.WriteLine("--------UPDATE PASS--------");
                        cmd = new SqlCommand("SELECT Count(*) FROM Session WHERE Id=18 AND staffID=2 AND slopeID=2 AND startTime=CAST('09:00:00' AS TIME) AND endTime=CAST('14:00:00' AS TIME) AND date=CAST('03-30-2017' AS DATETIME)", Connection);
                        i = (int)cmd.ExecuteScalar();

                        if(i > 0)
                        {
                            Console.WriteLine("--------VERIFY PASS--------");
                            Console.WriteLine("----------------ALL PASS----------------");
                            Connection.Close();
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("--------VERIFY FAIL--------");
                            Connection.Close();
                            return false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("--------UPDATE FAIL--------");
                        Connection.Close();
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Connection.Close();
                    MessageBox.Show(ex.ToString());
                    Console.WriteLine("--------UNKNOWN FAIL--------");
                    return false;
                }
            }
        }
    }
}
