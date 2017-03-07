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
    public partial class frmManagerMain : DevComponents.DotNetBar.Metro.MetroForm
    {
        //Size: 233, 633
        public frmManagerMain()
        {
            InitializeComponent();
        }

        private void frmManagerMain_Load(object sender, EventArgs e)
        {
            //Set up some things for the main menu
            lblVersion.Text = Application.ProductVersion;
            sideNav1.EnableClose = false;
            sideNav1.Dock = DockStyle.Fill;
        }

        private void sideNavItem2_Click(object sender, EventArgs e)
        {
            sideNav1.EnableClose = false;
            sideNav1.Dock = DockStyle.Fill;
        }

        private void sideNavItem3_Click(object sender, EventArgs e)
        {
            sideNav1.Dock = DockStyle.Left;
        }

        private void sideNavItem5_Click(object sender, EventArgs e)
        {
            sideNav1.Dock = DockStyle.Left;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Session_Managment.V2.frmSessionUpdate update = new Session_Managment.V2.frmSessionUpdate();
            update.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {

        }
    }
}