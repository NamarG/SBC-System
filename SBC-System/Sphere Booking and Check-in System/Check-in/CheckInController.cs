//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;
//using System.Windows.Forms;

//namespace Sphere_Booking_and_Check_in_System.Check_in
//{
//    class CheckInController
//    {
//        private int customerID;
//        private TextBox Id, firstName, lastName, emailAddress, phoneNumber, address;
//        private CheckBox member;

//        public CheckInController(int id, TextBox firstName)
//        {
//            customerID = id;
//            firstName = 

//        }

//        public int getCustomer(int id)
//        {
//            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
//            {
//                connection.Open();
//                SqlCommand command = new SqlCommand("SELECT * FROM Customer WHERE Id = @customer", connection);
//                command.Parameters.AddWithValue("customer", id);

//                SqlDataReader sdr = command.ExecuteReader();

//                while (sdr.Read())
//                {
//                    textBox1.Text = (sdr["Id"].ToString());
//                    textBox2.Text = (sdr["firstName"].ToString());
//                    textBox3.Text = (sdr["lastName"].ToString());
//                    textBox7.Text = (sdr["emailAddress"].ToString());
//                    textBox6.Text = (sdr["phoneNumber"].ToString());
//                    textBox5.Text = (sdr["address"].ToString());

//                    if (sdr[3].ToString() == "1")
//                    {
//                        checkBox2.Checked = true;
//                        checkBox2.Text = "Member";
//                    }
//                    else if (sdr[3].ToString() == "2")
//                    {
//                        checkBox2.Checked = true;
//                        checkBox2.Text = "Premium Member";
//                    }
//                    else
//                    {
//                        checkBox2.Checked = false;
//                        checkBox2.Text = "Non-Member";
//                    }

//                }

//                sdr.Close();

//                command = new SqlCommand("SELECT Id FROM Booking WHERE customerID = @customer", connection);
//                command.Parameters.AddWithValue("customer", id);
//                sdr = command.ExecuteReader();

//                while (sdr.Read())
//                {
//                    textBox8.Text = (sdr["Id"].ToString());
//                }
//                sdr.Close();
//                connection.Close();


//            }
//        }

//        internal void checkin()
//        {
//            throw new NotImplementedException();
//        }

//        public int saveCustomer(int id)
//        {
//            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
//            {
//                connection.Open();
//                SqlCommand command = new SqlCommand("UPDATE Booking SET checkedIn = 1 WHERE customerID=@cusID", connection);
//                command.Parameters.AddWithValue("cusID", id);
//                command.ExecuteNonQuery();
//                MessageBox.Show("You have successfully checked in.");
//                connection.Close();
//                return 1;
//            }
//        }
//    }

//}
  