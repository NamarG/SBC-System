using System;
using System.Windows.Forms;

namespace Sphere_Booking_and_Check_in_System.Session_Managment.V2
{
    class Controller
    {
        TextBox sessionID, staffID;
        ComboBox Slope, StartTime, EndTime;
        DateTimePicker date;
        CheckBox b;

        public Controller(TextBox sesID, TextBox staID, ComboBox s, DateTimePicker d, ComboBox start, ComboBox end, CheckBox t)
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

            if (i)
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
