using System;

namespace Sphere_Booking_and_Check_in_System.Session_Managment.V2
{
    interface BookingType
    {
        bool type(bool i);
    }

    class Group : BookingType
    {
        public bool type(bool i)
        {
            return true;
        }
    }

    class Individual : BookingType
    {
        public bool type(bool i)
        {
            return false;
        }
    }

    class Factory
    {
        static public BookingType getType(bool i)
        {
            BookingType type = null;

            switch (i)
            {
                case false:
                    type = new Individual();
                    break;
                case true:
                    type = new Group();
                    break;
            }
            return type;
        }
    }
}
