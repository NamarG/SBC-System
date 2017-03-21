using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Sphere_Booking_and_Check_in_System.Session_Managment.V2
{
    class update
    {
        public bool updateSession(int SessionID, int staffID, int slopeID, DateTime date, DateTime startTime, DateTime endTime)
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Session SET staffID=@staff, slopeID=@slope, startTime=@start, endTime=@end, date=@d WHERE Id = '" + SessionID + "'", Connection);
                    cmd.Parameters.AddWithValue("@staff", staffID);
                    cmd.Parameters.AddWithValue("@slope", slopeID);
                    cmd.Parameters.AddWithValue("@start", startTime);
                    cmd.Parameters.AddWithValue("@end", endTime);
                    cmd.Parameters.AddWithValue("@d", date);

                    cmd.ExecuteNonQuery();
                    int i = cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("UPDATE Staff_Scheduling SET booked=1 WHERE sessionID=@id", Connection);
                    cmd.Parameters.AddWithValue("@id", SessionID);
                    int j = cmd.ExecuteNonQuery();

                    if (i > 0 && j > 0)
                    {
                        MessageBoxEx.Show("Record Saved");
                        Connection.Close();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Unexpected error, record was not updated");
                        Connection.Close();
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Connection.Close();
                    MessageBox.Show("Unexpected error:" + ex.Message);
                    return false;
                }
            }
        }
    }

    class Staff
    {
        public bool checkStaff(int id)
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Count(*) FROM Staff WHERE Id=@staffID", Connection);
                    cmd.Parameters.AddWithValue("@staffID", id);
                    int i = (int)cmd.ExecuteScalar();

                    if (i > 0)
                    {
                        Connection.Close();
                        return true;
                    }
                    else
                    {
                        Connection.Close();
                        MessageBox.Show("Staff Memeber Doesn't Exist");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Connection.Close();
                    MessageBox.Show("Unexpected error:" + ex.Message);
                    return false;
                }
            }
        }
    }

    class Session
    {
        public bool checkSession(int id)
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Count(*) FROM Session WHERE Id=@sessionID", Connection);
                    cmd.Parameters.AddWithValue("@sessionID", id);
                    int i = (int)cmd.ExecuteScalar();

                    if (i > 0)
                    {
                        Connection.Close();
                        return true;
                    }
                    else
                    {
                        Connection.Close();
                        MessageBox.Show("Session Doesn't Exist");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Connection.Close();
                    return false;
                }
            }
        }
    }

    class Facade
    {
        private int sessionID, staffID, slopeID;
        private DateTime date, startTime, endTime;

        private update updateSession = new update();
        private Staff staff = new Staff();
        private Session session = new Session();

        public Facade(int id, int staff, int slope, DateTime d, DateTime s, DateTime e)
        {
            sessionID = id;
            staffID = staff;
            slopeID = slope;
            date = d;
            startTime = s;
            endTime = e;
        }

        public bool callUpdate()
        {
            bool success = true;

            if (!session.checkSession(sessionID))
            {
                success = false;
            }
            else if (!staff.checkStaff(staffID))
            {
                success = false;
            }
            else if (!updateSession.updateSession(sessionID, staffID, slopeID, date, startTime, endTime))
            {
                success = false;
            }
            return success;
        }
    }
}