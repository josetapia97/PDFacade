using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeTravelAgency.Subsystems
{
    public class CarRental
    {
        public void RentCar(string location)
        {
            Console.WriteLine($"car has been successfully leased in {location}");
        }
    }
}
