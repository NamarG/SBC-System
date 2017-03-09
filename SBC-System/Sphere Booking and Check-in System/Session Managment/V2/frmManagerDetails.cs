using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Sphere_Booking_and_Check_in_System.Session_Managment.V2
{
    public partial class frmManagerDetails : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmManagerDetails()
        {
            InitializeComponent();
        }

        private void frmManagerDetails_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Settings.Default.Manager;
        }
    }
}