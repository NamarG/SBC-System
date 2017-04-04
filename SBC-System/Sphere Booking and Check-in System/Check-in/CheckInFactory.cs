using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sphere_Booking_and_Check_in_System.Check_in
{
    class CheckInFactory
    {
        interface customertype
        {
            int type(int i);
        }

        class member : customertype
        {
            public int type(int i)
            {
                return 1;
            }
        }

        class premiumMember : customertype
        {
            public int type(int i)
            {
                return 2;
            }
        }

        class nonMember : customertype
        {
            public int type(int i)
            {
                return 2;
            }
        }

        class CustomerFactory
        {
            static public customertype gettype(bool i)
            {
                customertype type = null;
                switch (i)
                {
                    case false:
                        type = new member();
                        break;
                    case true:
                        type = new premiumMember();
                        break; 

                     else:
                        type = new nonMember();
                 
                        break;
                }
                return type;
            }
        }
    }

}
