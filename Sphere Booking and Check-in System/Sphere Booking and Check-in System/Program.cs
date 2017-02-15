using System;
using System.Windows.Forms;

namespace Sphere_Booking_and_Check_in_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Session_Managment.frmManagerLogin());
        }
    }
}
