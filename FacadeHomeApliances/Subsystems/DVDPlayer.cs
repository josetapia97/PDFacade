using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeHomeApliances.Subsystems
{
    public class DVDPlayer 
    {
        public void On()
        {
            Console.WriteLine("DVD player turned on");
        }
        public void Off() 
        {
            Console.WriteLine("DVD player turned off");
        }
        public void PlayMovie(string movieName)
        {
            Console.WriteLine($"Reproducing the movie '{movieName}'");
        }
    }
}
