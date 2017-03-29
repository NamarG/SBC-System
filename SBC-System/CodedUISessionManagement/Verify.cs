using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CodedUISessionManagement
{
    class Verify
    {
        public Verify()
        {

        }

        public bool getSession(string sesID, string sID, string d, string sTime, string eTime)
        {
            //Validation that the data is there
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Count(*) FROM Session WHERE sessionID=@sesID, staffID=@sID, startTime=@sTime, endTime=@eTime, date=@d", Connection);
                    cmd.Parameters.AddWithValue("sesID", sesID);
                    cmd.Parameters.AddWithValue("sID", sID);
                    cmd.Parameters.AddWithValue("sTime", sTime);
                    cmd.Parameters.AddWithValue("eTime", eTime);
                    cmd.Parameters.AddWithValue("d", d);

                    int i = (int)cmd.ExecuteScalar();

                    if (i > 0)
                    {
                        Connection.Close();
                        return true;
                    }
                    else
                    {
                        Connection.Close();
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
}
