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
    public partial class frmdate : Form
    {
        public frmdate()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    SqlDataAdapter datecheck = new SqlDataAdapter("SELECT * FROM [Session] WHERE date ='" + dateTimePicker1.Value.ToLongDateString() +"'" , Connection);
                    DataTable datedata = new DataTable(); //datagridviewer will be filled with data of sessions available on the day which has less than 30 people booked onit.

                    datecheck.Fill(datedata);
                    dataGridView1.DataSource = datedata;
                    Connection.Close();
                }
        }
    }
}
