using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeTravelAgency.Subsystems
{
    public class HotelBooking
    {
        public void BookHotel(string destination)
        {
            Console.WriteLine($"Hotel has been booked successfully in {destination}");
        }
    }
}
