using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sphere_Booking_and_Check_in_System.Booking
{
    class factory
    {
        int fcusidBox, fsessionBox, fstaffschBox;
        DateTime date;
        int memtype;

        public factory(int cusid, int sessionb, int staffsch, DateTime datetemp,int typeofmem)
        {
           
            fcusidBox = cusid;
            fsessionBox = sessionb;
            fstaffschBox = staffsch;
            date = datetemp;
            memtype = typeofmem;
        }
     public void factoryset()
        {
            if (memtype == 1)
            {
                premBooking book = new premBooking(fcusidBox, fsessionBox, fstaffschBox,date);
                book.makeBooking();
            }

            else if(memtype == 2)
            {
                memBooking book = new memBooking(fcusidBox, fsessionBox, fstaffschBox, date);
                book.makeBooking();
            }
            else
            {
                standardBooking book = new standardBooking(fcusidBox, fsessionBox, fstaffschBox, date);
                book.makeBooking();
            }
        }
    }
}
