using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Sphere_Booking_and_Check_in_System.Session_Managment.V2
{
    class Update
    {
        public bool updateSession(int SessionID, int staffID, int slopeID, DateTime date, DateTime startTime, DateTime endTime, bool group)
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Session SET staffID=@staff, slopeID=@slope, startTime=@start, endTime=@end, date=@d, groupBooking=@group WHERE Id=@sesID", Connection);
                    cmd.Parameters.AddWithValue("@staff", staffID);
                    cmd.Parameters.AddWithValue("@slope", slopeID);
                    cmd.Parameters.AddWithValue("@start", startTime);
                    cmd.Parameters.AddWithValue("@end", endTime);
                    cmd.Parameters.AddWithValue("@d", date);
                    cmd.Parameters.AddWithValue("@group", group);
                    cmd.Parameters.AddWithValue("@sesID", SessionID);

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

    class CheckStaff
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

    class CheckSession
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

    class Session
    {
        private int sessionID, staffID, slopeID;
        private DateTime date, startTime, endTime;
        private bool group;

        private Update updateSession = new Update();
        private CheckStaff staff = new CheckStaff();
        private CheckSession session = new CheckSession();

        public Session(int id, int staff, int slope, DateTime d, DateTime s, DateTime e, bool g)    //Constructor
        {
            SessionID = id;
            StaffID = staff;
            Slope = slope;
            Date = d;
            StartTime = s;
            EndTime = e;
            group = g;
        }

        public Session()    //Overload for searching
        {

        }

        public int SessionID { get { return sessionID; } set { sessionID = value; } }
        public int StaffID { get { return staffID; } set { staffID = value; } }
        public int Slope { get { return slopeID; } set { slopeID = value; } }
        public DateTime Date { get { return date; } set { date = value; } }
        public DateTime StartTime { get { return startTime; } set { startTime = value; } }
        public DateTime EndTime { get { return endTime; } set { endTime = value; } }
        public bool Group { get { return group; } set { group = value; } }

        public bool Update()
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
            else if (!updateSession.updateSession(sessionID, staffID, slopeID, date, startTime, endTime, group))
            {
                success = false;
            }
            return success;
        }

        public bool getSession(int id)
        {
            if(session.checkSession(id))
            {
                using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    try
                    {
                        Connection.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM Session WHERE Id=@sessionID", Connection);
                        cmd.Parameters.AddWithValue("@sessionID", id);
                        SqlDataReader sdr = cmd.ExecuteReader();

                        while (sdr.Read())
                        {
                            SessionID = int.Parse(sdr["Id"].ToString());
                            StaffID = int.Parse(sdr["slopeID"].ToString());
                            Slope = int.Parse(sdr["staffID"].ToString());
                            Date = Convert.ToDateTime(sdr["date"].ToString());
                            StartTime = Convert.ToDateTime(sdr["startTime"].ToString());
                            EndTime = Convert.ToDateTime(sdr["endTime"].ToString());
                            Group = Convert.ToBoolean(sdr["groupBooking"].ToString());
                        }
                        sdr.Close();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Connection.Close();
                        return false;
                    }
                }
            }
            return true;
        }
    }
}