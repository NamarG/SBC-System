using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sphere_Booking_and_Check_in_System.Check_in
{
    class Check_In
    {
        private int customerID;

        public Check_In(int id)
        {
            customerID = id; //constructs new object.
        }

        public bool checkin()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Booking SET checkedIn = 1 WHERE customerID=@cusID", connection);
                command.Parameters.AddWithValue("cusID", customerID);
                command.ExecuteNonQuery();
                MessageBox.Show("You have successfully checked in.");
                connection.Close();
                return true;
            }
        }
    }
}
