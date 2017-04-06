using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sphere_Booking_and_Check_in_System.Scheduling
{
    public partial class frmAddNew : Form
    {
        public frmAddNew()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30")) // making connect with the database
            {
               if ( DatePicker.Text == String.Empty || TimePickerStart.Text == String.Empty || TimePickerEnd.Text == String.Empty || cbopleid.Text == String.Empty || txtStaff.Text == String.Empty) // checking if any of the input are empty
                {
                    MessageBox.Show ("Please fill in missing values"); // if any of the input are empty show a message box
                }
                else
                {
                    try
                    {
                        Connection.Open(); // connecting to the database
                        SqlCommand cmd = new SqlCommand(@"INSERT INTO Session ([staffID], [slopeID], [startTime], [endTime], [date], [limit]) VALUES (@staffID, @slopeID, @startTime, @endTime, @date, @limit);", Connection); // input the data from the form into the database
                        cmd.Parameters.AddWithValue("@slopeID", cbopleid.Text);
                        cmd.Parameters.AddWithValue("@staffID", txtStaff.Text);
                        cmd.Parameters.AddWithValue("@date", DatePicker.Text);
                        cmd.Parameters.AddWithValue("@startTime", TimePickerStart .Text);
                        cmd.Parameters.AddWithValue("@endTime", TimePickerEnd.Text);
                        cmd.Parameters.AddWithValue("@limit", 0);


                        int a = cmd.ExecuteNonQuery(); // check if the data was added to the database
                        Connection.Close();
                        // so message box showing the the data was add the the database
                        if (a == 1) 
                        {
                            MessageBox.Show("Session has been added");
     
                         
                            txtStaff.Clear();
                            cbopleid.Text = " ";
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
            }

        private void button2_Click(object sender, EventArgs e)
        {
            Scheduling.frmdate checkdate = new Scheduling.frmdate();
            checkdate.Show();// open the check date form 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Scheduling.frmstaff checkstaff = new Scheduling.frmstaff();
            checkstaff.Show(); // open the check staff form 
        }
    }
    }
}

