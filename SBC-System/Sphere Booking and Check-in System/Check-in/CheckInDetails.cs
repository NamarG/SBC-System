using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sphere_Booking_and_Check_in_System.Check_in
{
    public partial class CheckInDetails : Form
    {
        int id;
        public CheckInDetails(int customerID)
        {
            InitializeComponent();
            id = customerID;
        }

        private void CheckInDetails_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckIn checkin = new Check_in.CheckIn();
            this.Close();
            checkin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckInController check = new CheckInController(int.Parse(textBox1.Text.ToString())); //making new object.

            //check.checkin(); //calls function, to return back to checkin.
        }
    }
}
