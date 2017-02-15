using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sphere_Booking_and_Check_in_System.Session_Managment
{
    public partial class frmSessionManagementMain : Form
    {
        public frmSessionManagementMain()
        {
            InitializeComponent();

            FormClosing += new FormClosingEventHandler(frmSessionManagementMain_FormClosing);
        }

        private void frmSessionManagementMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Manager Log Out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                frmManagerLogin login = new frmManagerLogin();
                login.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddNew add = new frmAddNew();
            add.Show();
        }

        private void logOutToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Manager Log Out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                frmManagerLogin login = new frmManagerLogin();
                login.Show();
            }
        }
    }
}
