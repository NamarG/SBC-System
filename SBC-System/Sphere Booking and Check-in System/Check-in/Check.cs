using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sphere_Booking_and_Check_in_System.Check_in
{
    class CheckInController
    {
        private int customerID;
        private TextBox Id, firstName, lastName, emailAddress, phoneNumber, address;
        private CheckBox member;

        public CheckInController(int id, TextBox fName, TextBox lName, TextBox eAddress, TextBox pNumber, TextBox addr, CheckBox mem)
        {
            customerID = id;
            firstName = fName;
            lastName = lName;
            emailAddress = eAddress;
            phoneNumber = pNumber;
            address = addr;
            member = mem;
        }
        
        public controller()
        {

        }

        public int getCustomer(int id)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Customer WHERE Id = @customer", connection);
                command.Parameters.AddWithValue("customer", id);

                SqlDataReader sdr = command.ExecuteReader();

                while (sdr.Read())
                {
                    textBox1.Text = (sdr["Id"].ToString());
                    textBox2.Text = (sdr["firstName"].ToString());
                    textBox3.Text = (sdr["lastName"].ToString());
                    textBox7.Text = (sdr["emailAddress"].ToString());
                    textBox6.Text = (sdr["phoneNumber"].ToString());
                    textBox5.Text = (sdr["address"].ToString());

                    if (sdr[3].ToString() == "1")
                    {
                        checkBox2.Checked = true;
                        checkBox2.Text = "Member";
                    }
                    else if (sdr[3].ToString() == "2")
                    {
                        checkBox2.Checked = true;
                        checkBox2.Text = "Premium Member";
                    }
                    else
                    {
                        checkBox2.Checked = false;
                        checkBox2.Text = "Non-Member";
                    }

                }

                sdr.Close();

                command = new SqlCommand("SELECT Id FROM Booking WHERE customerID = @customer", connection);
                command.Parameters.AddWithValue("customer", id);
                sdr = command.ExecuteReader();

                while (sdr.Read())
                {
                    textBox8.Text = (sdr["Id"].ToString());
                }
                sdr.Close();
                connection.Close();


            }
        }

        internal void checkin()
{
    throw new NotImplementedException();
}

public int saveCustomer(int id)
{
    using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
    {
        connection.Open();
        SqlCommand command = new SqlCommand("UPDATE Booking SET checkedIn = 1 WHERE customerID=@cusID", connection);
        command.Parameters.AddWithValue("cusID", id);
        command.ExecuteNonQuery();
        MessageBox.Show("You have successfully checked in.");
        connection.Close();
        return 1;
    }
}
    }


    //public bool manualTest()
    //{
    //    Console.WriteLine("Start test:");
    //    using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
    //    {
    //        try
    //        {
    //            Connection.Open();
    //            SqlCommand cmd = new SqlCommand("UPDATE Session SET staffID=2, slopeID=2, startTime=CAST('09:00' AS TIME), endTime=CAST('14:00' AS TIME), date=CAST('03-30-2017' AS DATETIME) WHERE Id=18", Connection);
    //            int i = cmd.ExecuteNonQuery();

    //            if (i > 0)
    //            {
    //                Console.WriteLine("--------UPDATE PASS--------");
    //                cmd = new SqlCommand("SELECT Count(*) FROM Session WHERE Id=18 AND staffID=2 AND slopeID=2 AND startTime=CAST('09:00:00' AS TIME) AND endTime=CAST('14:00:00' AS TIME) AND date=CAST('03-30-2017' AS DATETIME)", Connection);
    //                i = (int)cmd.ExecuteScalar();

    //                if (i > 0)
    //                {
    //                    Console.WriteLine("--------VERIFY PASS--------");
    //                    Console.WriteLine("----------------ALL PASS----------------");
    //                    Connection.Close();
    //                    return true;
    //                }
    //                else
    //                {
    //                    Console.WriteLine("--------VERIFY FAIL--------");
    //                    Connection.Close();
    //                    return false;
    //                }
    //            }
    //            else
    //            {
    //                Console.WriteLine("--------UPDATE FAIL--------");
    //                Connection.Close();
    //                return false;
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            Connection.Close();
    //            MessageBox.Show(ex.ToString());
    //            Console.WriteLine("--------UNKNOWN FAIL--------");
    //            return false;
    //        }
        }