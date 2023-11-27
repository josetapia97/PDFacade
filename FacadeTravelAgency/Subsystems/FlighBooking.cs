using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeTravelAgency.Subsystems
{
    public class FlighBooking
    {
        public void BookFlight(string destination)
        {
            Console.WriteLine($"the flight has been booked successfully in {destination}");
        }
    }
}
