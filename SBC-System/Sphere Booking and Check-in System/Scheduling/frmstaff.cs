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
    public partial class frmstaff : Form
    {
        public frmstaff()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {


            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                SqlDataAdapter staffcheck = new SqlDataAdapter("SELECT * FROM [Staff_Scheduling] WHERE date ='" + dateTimePicker1.Value.ToLongDateString()  + "'", Connection); // // get the information from staff_schedling
                DataTable staffdata = new DataTable(); // show staff members who are not booked on the day

                staffcheck.Fill(staffdata);
                dataGridView1.DataSource = staffdata;
                Connection.Close();
            }
        }
    }
}
