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

        private void BookingNav_Click(object sender, EventArgs e)
        {
            Booking.BookingForm bf = new Booking.BookingForm();
            this.Hide(); //this while hide the main form.
            bf.ShowDialog(); //this opens booking form "bf"
        }
    }
}
