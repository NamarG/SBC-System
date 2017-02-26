using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Sphere_Booking_and_Check_in_System.Booking
{
    public partial class BookingForm : Form
    {

        bool isreg = false; //set to false will change if user is in the system.
        SqlConnection con; //connection
        string connectionString;

        public BookingForm()
        {
            InitializeComponent();
            connectionString = connectionString = ConfigurationManager.ConnectionStrings["Sphere_Booking_and_Check_in_System.Properties.Settings.mainDatabaseConnectionString"].ConnectionString;
        }

        private void CheckId_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand checkid = new SqlCommand();
            checkid.CommandText = "select * from [Customer]";
            checkid.Connection = con;

            SqlDataReader rd = checkid.ExecuteReader();
            while (rd.Read())
            {
                memcheck.Text = "............................";
                if (rd[0].ToString() == idBox.Text) //the zero here is calling to the id col
                { //here we are saying that if rd var is == to the value user input is a match then isreg before true.
                    isreg = true;
                    //we then print it out to the label.
                }
                if (isreg == true)
                {
                    if (rd[3].ToString() == "True")
                    {
                        memcheck.Text = "Member: £15";
                    }
                    else
                    {
                        memcheck.Text = "Non-Member: £25";
                    }
                }
                //code to ask for the correct price from the user
            }
            if (isreg == true)
            {
                idLabel.Text = "Is registerd";
            }
            else
            {
                idLabel.Text = "Could not find";
            }
           
       
            isreg = false;
            con.Close();
        }

        private void checkEmail_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand checkEmail = new SqlCommand();
            checkEmail.CommandText = "select * from [Customer]";
            checkEmail.Connection = con;

            SqlDataReader rd = checkEmail.ExecuteReader();
            while (rd.Read())
            {
                if (rd[4].ToString() == emailBox.Text) //the 4 here is calling to the Email col
                { //here we are saying that if rd var is == to the value user input is a match then isreg before true.
                    isreg = true;
                    //we then print it out to the label.
                }

            }
            if (isreg == true)
            {
                emailLabel.Text = "Is registerd";
            }
            else
            {
                emailLabel.Text = "Could not find";
            }
            isreg = false;
            con.Close();
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDatabaseDataSet.Session' table. You can move, or remove it, as needed.
           // this.sessionTableAdapter.Fill(this.mainDatabaseDataSet.Session);

        }
        private void search_Click(object sender, EventArgs e)
        { //this code needs to be commented and talked about
            con = new SqlConnection(connectionString);
            SqlDataAdapter sdf = new SqlDataAdapter("SELECT * FROM [Session] WHERE date ='" + dateTimePicker1.Value.ToLongDateString() + "' AND startTime >='"+startTimeBox.Text.ToString()+"' AND endTime <='"+startTimeBox.Text.ToString()+"'", con);
            DataTable sd = new DataTable();

            sdf.Fill(sd);
            dataGridView1.DataSource = sd;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString); //create a new sql connection
            if (cusID.Text == String.Empty ||
                    slopeComboBox.Text == String.Empty || dateTimePicker2.Text == String.Empty || textStartTime.Text == String.Empty ||
                    textEndTime.Text == String.Empty || payment.Text == String.Empty) //this code here will check if the all the values have been entered
            {
                MessageBox.Show("Error, missing valeus", "Please Complete Form", MessageBoxButtons.OK, MessageBoxIcon.Error); //show the error if they are not.
            }
            else
            {
                try
                {
                    con.Open(); // open my sql connection that i created above
                    SqlCommand cmd = new SqlCommand("INSERT INTO Session (staffID, customerID, slopeID, startTime, endTime, date) VALUES (@staffID, @customerID, @slopeID, @startTime, @endTime, @date) SELECT SCOPE_IDENTITY();", con);
                    //simple insert statement, where we get the auto incremented value as "int"

                    cmd.Parameters.AddWithValue("@staffID", staffID.Text);
                    cmd.Parameters.AddWithValue("@customerID", cusID.Text);
                    cmd.Parameters.AddWithValue("@slopeID", slopeComboBox.Text);
                    cmd.Parameters.AddWithValue("@startTime", textStartTime.Text.ToString());
                    cmd.Parameters.AddWithValue("@endTime", textEndTime.Text.ToString());
                    cmd.Parameters.AddWithValue("@date", dateTimePicker2.Value);

                    //add the data to the tables
                
                    int a = cmd.ExecuteNonQuery(); 
                    SqlDataReader rd = cmd.ExecuteReader();


                    rd.Read();
                    string id = rd[0].ToString(); //here we take the auto incremented sessionID and store it in (id) to be used later.
                    rd.Close();
                    
                    

                    SqlCommand cmd2 = new SqlCommand("INSERT INTO Booking (staffID, customerID, cost, sessionID) VALUES (@staffID, @customerID, @cost, @sessionID)",con);
                    cmd2.Parameters.AddWithValue("@staffID", staffID.Text);
                    cmd2.Parameters.AddWithValue("@customerID", cusID.Text);
                    cmd2.Parameters.AddWithValue("@cost", payment.Text);
                    cmd2.Parameters.AddWithValue("@sessionID", id);
                    int b = cmd2.ExecuteNonQuery();
                    //adding data to the booking tables and using the (id = sessionid) which we got by using SCOPE_IDENTITY()
                    if (a == 1 && b == 1)
                    {
                        MessageBox.Show("Session has been added: "); //simple error checks

                    }
                    else
                    {
                        MessageBox.Show("Session couldn't be added at this time");
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error:" + ex.Message);
                }
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 bf = new Form1();
            this.Hide(); //this while hide the bookingform form.
            bf.ShowDialog(); //this opens form1 form "bf"
        }
    }
}
