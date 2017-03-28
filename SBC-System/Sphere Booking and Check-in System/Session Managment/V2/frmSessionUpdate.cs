using System;
using DevComponents.DotNetBar;
using System.Data.SqlClient;
using System.Windows.Forms;
using Sphere_Booking_and_Check_in_System.Session_Managment.V2;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Data;

namespace Sphere_Booking_and_Check_in_System.Session_Managment.V2
{
    public partial class frmSessionUpdate : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmSessionUpdate()
        {
            InitializeComponent();
        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            Session_Managment.V2.frmFindSession findSession = new Session_Managment.V2.frmFindSession();
            findSession.Show();
            findSession.SetDesktopLocation(this.Location.X + this.Size.Width, this.Location.Y);
            findSession.Owner = this;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Session session = new Session();
            session.getSession(int.Parse(txtSearchBox.Text.ToString()));
            txtStaffID.Text = session.StaffID.ToString();
            comboBoxSlope.Text = session.Slope.ToString();
            dateTimePicker1.Text = session.Date.ToShortDateString();
            comboBoxEx1.Text = session.StartTime.ToShortTimeString();
            comboBoxEx2.Text = session.EndTime.ToShortTimeString();
            checkBox1.Checked = session.Group;

            btnSubmit.Enabled = true;
        }

        private void btnFindStaff_Click(object sender, EventArgs e)
        {
            Session_Managment.V2.frmFindStaff frmFindStaff = new Session_Managment.V2.frmFindStaff();
            frmFindStaff.Show();
            frmFindStaff.SetDesktopLocation(this.Location.X + this.Size.Width, this.Location.Y);
            frmFindStaff.Owner = this;
        }

        private void frmSessionUpdate_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            Properties.Settings.Default.staffID = 0;
        }

        private void txtStaffID_Click(object sender, System.EventArgs e)
        {
            if (Properties.Settings.Default.staffID > 0)
            {
                txtStaffID.Text = Properties.Settings.Default.staffID.ToString();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            BookingType type = null;
            type = Factory.getType(checkBox1.Checked);
            bool getType = type.type(checkBox1.Checked);

            Session ses = new Session(int.Parse(txtSearchBox.Text.ToString()), int.Parse(txtStaffID.Text.ToString()), int.Parse(comboBoxSlope.Text.ToString()), Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDateTime(comboBoxEx1.Text), Convert.ToDateTime(comboBoxEx2.Text), getType);
            bool i = ses.Update();

            if(i)
            {
                txtSearchBox.Clear();
                comboBoxSlope.Text = "Select Slope....";
                txtStaffID.Text = "";
                comboBoxEx1.Text = "";
                comboBoxEx2.Text = "";
                dateTimePicker1.Text = "";
                checkBox1.Checked = false;

                btnSubmit.Enabled = false;
            }
        }
    }
}