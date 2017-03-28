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
            Controller control = new Controller(txtSearchBox, txtStaffID, comboBoxSlope, dateTimePicker1, comboBoxEx1, comboBoxEx2, checkBox1);
            bool i = control.getSession();
            if(i)
            {
                btnSubmit.Enabled = true;
            }
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
            Controller control = new Controller(txtSearchBox, txtStaffID, comboBoxSlope, dateTimePicker1, comboBoxEx1, comboBoxEx2, checkBox1);

            bool i = control.Update();

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

    class Controller : frmSessionUpdate
    {
        TextBox sessionID, staffID;
        ComboBox Slope, StartTime, EndTime;
        DateTimePicker date;
        CheckBox b;

        public Controller(TextBox sesID, TextBox staID , ComboBox s, DateTimePicker d, ComboBox start, ComboBox end, CheckBox t)
        {
            sessionID = sesID;
            staffID = staID;
            Slope = s;
            date = d;
            StartTime = start;
            EndTime = end;
            b = t;
        }

        public bool Update()
        {
            BookingType type = null;
            type = Factory.getType(b.Checked);
            bool getType = type.type(b.Checked);

            Session ses = new Session(int.Parse(sessionID.Text.ToString()), int.Parse(staffID.Text.ToString()), int.Parse(Slope.Text.ToString()), Convert.ToDateTime(date.Text), Convert.ToDateTime(StartTime.Text), Convert.ToDateTime(EndTime.Text), getType);
            bool i = ses.Update();
            return i;
        }

        public bool getSession()
        {
            Session session = new Session();
            bool i = session.getSession(int.Parse(sessionID.Text.ToString()));

            if(i)
            {
                staffID.Text = session.StaffID.ToString();
                Slope.Text = session.Slope.ToString();
                date.Text = session.Date.ToShortDateString();
                StartTime.Text = session.StartTime.ToShortTimeString();
                EndTime.Text = session.EndTime.ToShortTimeString();
                b.Checked = session.Group;
            }
            return i;
        }

        public bool Save()
        {
            BookingType type = null;
            type = Factory.getType(b.Checked);
            bool getType = type.type(b.Checked);

            Session ses = new Session(int.Parse(sessionID.Text.ToString()), int.Parse(staffID.Text.ToString()), int.Parse(Slope.Text.ToString()), Convert.ToDateTime(date.Text), Convert.ToDateTime(StartTime.Text), Convert.ToDateTime(EndTime.Text), getType);
            bool i = ses.Update();
            return i;
        }
    }
}