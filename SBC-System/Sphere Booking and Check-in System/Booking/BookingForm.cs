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
                    if (rd[3].ToString() == "1")
                    {
                        memcheck.Text = "Member: £20";
                        payment.Text = "20";
                    }
                    else if (rd[3].ToString() == "2")
                    {
                        memcheck.Text = "Prm Member: £15";
                        payment.Text = "15";
                    }
                    else
                    {
                        memcheck.Text = "Non-Member: £25";
                        payment.Text = "25";
                    }
                }
                //code to ask for the correct price from the user so no mistakes are made
            }
            if (isreg == true)
            {
                cusidBox.Text = idBox.Text;
                idLabel.Text = "Is registerd";
            }
            else
            {
                idLabel.Text = "Could not find";
            }
           
       
            isreg = false;
            con.Close();
           
            con = new SqlConnection(connectionString);
            SqlDataAdapter checkup = new SqlDataAdapter("SELECT * FROM [Customer] WHERE id ='" + idBox.Text + "'", con); //this will get all the data
            DataTable sd = new DataTable();

            checkup.Fill(sd);
            dataGridView2.DataSource = sd;
        }

        private void checkEmail_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand checkEmail = new SqlCommand();
            checkEmail.CommandText = "select * from [Customer]";
            checkEmail.Connection = con;

            SqlDataReader rd = checkEmail.ExecuteReader();

            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"; //check for invalid inputs
            RegexStringValidator myRegexValidator = new RegexStringValidator(pattern);

            try
            {
                myRegexValidator.Validate(emailBox.Text); //checking what has been typed and if it matches the pattern. 

            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Email");

            }

            while (rd.Read())
            {
                if (rd[4].ToString() == emailBox.Text) //the 4 here is calling to the Email col
                { //here we are saying that if rd var is == to the value user input is a match then isreg before true.
                    isreg = true;
                    //we then print it out to the label.
                }
                if (isreg == true)
                {
                    if (rd[3].ToString() == "1")
                    {
                        memcheck.Text = "Member: £20";
                        payment.Text = "20";
                    }
                    else if (rd[3].ToString() == "2")
                    {
                        memcheck.Text = "Prm Member: £15";
                        payment.Text = "15";
                    }
                    else
                    {
                        memcheck.Text = "Non-Member: £25";
                        payment.Text = "25";
                    }
                }
                //code to ask for the correct price from the user so no mistakes are made

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
            con = new SqlConnection(connectionString);
            SqlDataAdapter checkup = new SqlDataAdapter("SELECT * FROM [Customer] WHERE emailAddress ='" + emailBox.Text + "'", con); //this will get all the data where email matches
            DataTable sd = new DataTable();

            checkup.Fill(sd);
            dataGridView2.DataSource = sd;
            con.Close();


        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDatabaseDataSet.Staff_Scheduling' table. You can move, or remove it, as needed.
            this.staff_SchedulingTableAdapter.Fill(this.mainDatabaseDataSet.Staff_Scheduling);
            // TODO: This line of code loads data into the 'mainDatabaseDataSet.Booking' table. You can move, or remove it, as needed.
           

        }
        private void search_Click(object sender, EventArgs e)
        { //this code needs to be commented and talked about
            con = new SqlConnection(connectionString);
            SqlDataAdapter sdf = new SqlDataAdapter("SELECT * FROM [Session] WHERE date ='" + dateTimePicker1.Value.ToLongDateString() +"' AND limit < 30" , con);
            DataTable sd = new DataTable(); //datagridviewer will be filled with data of sessions available on the day which has less than 30 people booked onit.

            sdf.Fill(sd);
            dataGridView1.DataSource = sd;
            con.Close();

            con = new SqlConnection(connectionString);
            SqlDataAdapter staffcheck = new SqlDataAdapter("SELECT * FROM [Staff_Scheduling] WHERE date ='" + dateTimePicker1.Value.ToLongDateString() +"' AND booked =  0", con); //this will get all the data where email matches
            DataTable staffdata = new DataTable(); //datagridviewer will be filled with with staff members who are not booked on the day the customer wants one.

            staffcheck.Fill(staffdata);
            dataGridView3.DataSource = staffdata;
            con.Close();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString); //create a new sql connection
            if (cusidBox.Text == String.Empty ||
                    sessionBox.Text == String.Empty || dateTimePicker1.Text == String.Empty 
                     || payment.Text == String.Empty) //this code here will check if the all the values have been entered
            {
                MessageBox.Show("Error, missing valeus", "Please Complete Form", MessageBoxButtons.OK, MessageBoxIcon.Error); //show the error if they are not.
            }
            else
            {
                try
                {
                  

                    
                    con.Open(); // open my sql connection that i created above
                    SqlCommand limit_increment = new SqlCommand("UPDATE Session set limit = limit + 1 WHERE id ='" + this.sessionBox.Text + "';", con);
                    int incremnt_check = limit_increment.ExecuteNonQuery();
                    if (incremnt_check != 1)
                    {
                        MessageBox.Show("Failed to increment Session limit"); //simple error checks

                    }
                    con.Close();  //this will incrment the limit com in session tables everytime user enters 



                    if (staffschBox.Text != String.Empty)
                    {
                        con.Open();
                        SqlCommand staff_Booked = new SqlCommand("UPDATE Staff_Scheduling set booked = 1 WHERE id ='" + staffschBox.Text + "';", con);
                        int booked_true = staff_Booked.ExecuteNonQuery();
                        if (booked_true != 1)
                        {
                            MessageBox.Show("Failed to book staff with customer");
                        }
                        
                    }
                    
               
                    SqlCommand cmd2 = new SqlCommand("INSERT INTO Booking (staff_Sch, customerID, cost, sessionID) VALUES (@staff_Sch, @customerID, @cost, @sessionID)",con);
                    cmd2.Parameters.AddWithValue("@staff_Sch", staffschBox.Text);
                    cmd2.Parameters.AddWithValue("@customerID", cusidBox.Text);
                    cmd2.Parameters.AddWithValue("@cost", payment.Text);
                    cmd2.Parameters.AddWithValue("@sessionID", sessionBox.Text);
                    int b = cmd2.ExecuteNonQuery();
                    
                    if (b == 1)
                    {
                        MessageBox.Show("Booking has been added: "); //simple error checks

                    }
                    else
                    {
                        MessageBox.Show("Booking couldn't be added at this time");
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
            this.Close(); //this while hide the bookingform form.
        }


        int a, b, c;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            b = e.RowIndex; //needs to know the row that has been clicked
            DataGridViewRow row = dataGridView1.Rows[b];
            sessionBox.Text = row.Cells[0].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            a = e.RowIndex; //needs to know the row that has been clicked
            DataGridViewRow row = dataGridView2.Rows[a];
            cusidBox.Text = row.Cells[0].Value.ToString();

        }
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            c = e.RowIndex; //needs to know the row that has been clicked
            DataGridViewRow row = dataGridView3.Rows[c];
            staffschBox.Text = row.Cells[0].Value.ToString();
        }

    }
}
