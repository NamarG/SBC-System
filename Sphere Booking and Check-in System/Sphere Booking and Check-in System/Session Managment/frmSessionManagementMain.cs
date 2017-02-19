using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sphere_Booking_and_Check_in_System.Session_Managment
{
    public partial class frmSessionManagementMain : Form
    {
        public frmSessionManagementMain()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Manager Log Out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                frmManagerLogin login = new frmManagerLogin();
                login.Show();
            }
        }

        private void addNewSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNew newSession = new frmAddNew();
            newSession.MdiParent = this;
            newSession.Show();
        }
    }
}
