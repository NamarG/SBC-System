using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sphere_Booking_and_Check_in_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Session_Managment.frmManagerLogin login = new Session_Managment.frmManagerLogin();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Booking.BookingForm book = new Booking.BookingForm();
            book.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Check_in.CheckIn check = new Check_in.CheckIn();
            check.Show();
        }
    }
}
