using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sphere_Booking_and_Check_in_System.Check_in
{
    class CheckInController
    {
        private int customerID;

        public CheckInController(int id)
        {
            customerID = id; //constructs new object.
        }

        public int CustomerID { get { return CustomerID; } set { CustomerID = value; } }
    }
}
