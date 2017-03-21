using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sphere_Booking_and_Check_in_System.Booking
{
    public class Booking
    {
        int cusidBox, sessionBox, staffschBox, payment;
        DateTime date;

        public Booking(int cusid, int sessionb, int staffsch, DateTime date2, int monies)
        {
            cusidBox = cusid;
            sessionBox = sessionb;
            staffschBox = staffsch;
            date = date2;
            payment = monies;



        }

        bool isreg = false; //set to false will change if user is in the system.
        SqlConnection con; //connection
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDatabase.mdf;Integrated Security = True; Connect Timeout = 30";








        public bool makeBooking()
        {


            con = new SqlConnection(connectionString); //create a new sql connection
            try
            {

                con.Open(); // open my sql connection that i created above
                SqlCommand limit_increment = new SqlCommand("UPDATE Session set limit = limit + 1 WHERE id ='" + sessionBox + "';", con);
                int incremnt_check = limit_increment.ExecuteNonQuery();
                if (incremnt_check != 1)
                {
                    MessageBox.Show("Failed to increment Session limit"); //simple error checks
                    return false;
                }
                con.Close();  //this will incrment the limit com in session tables everytime user enters 





                con.Open();
                SqlCommand staff_Booked = new SqlCommand("UPDATE Staff_Scheduling set booked = 1 WHERE id ='" + staffschBox + "';", con);
                int booked_true = staff_Booked.ExecuteNonQuery();
                if (booked_true != 1)
                {
                    MessageBox.Show("Failed to book staff with customer");
                    return false;
                }




                SqlCommand cmd2 = new SqlCommand("INSERT INTO Booking (staff_Sch, customerID, cost, sessionID) VALUES (@staff_Sch, @customerID, @cost, @sessionID)", con);
                cmd2.Parameters.AddWithValue("@staff_Sch", staffschBox);
                cmd2.Parameters.AddWithValue("@customerID", cusidBox);
                cmd2.Parameters.AddWithValue("@cost", payment);
                cmd2.Parameters.AddWithValue("@sessionID", sessionBox);
                int b = cmd2.ExecuteNonQuery();

                if (b == 1)
                {
                    MessageBox.Show("Booking has been added: "); //simple error checks
                    return true;
                }
                else
                {
                    MessageBox.Show("Booking couldn't be added at this time");
                    return false;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error:" + ex.Message);
                return false;
            }




            return false;
        }
    }
}
