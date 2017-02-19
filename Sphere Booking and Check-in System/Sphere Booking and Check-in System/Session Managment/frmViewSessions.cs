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
    public partial class frmViewSessions : Form
    {
        public frmViewSessions()
        {
            InitializeComponent();
        }

        private void frmViewSessions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDatabaseDataSet.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter.Fill(this.mainDatabaseDataSet.Session);
        }
    }
}
