using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeHomeApliances.Subsystems
{
    public class Speakers
    {
        public void On()
        {
            Console.WriteLine("DVD player turned on");
        }
        public void Off()
        {
            Console.WriteLine("DVD player turned off");
        }

        public void ChangeVolume(int volume) 
        {
            if (volume >= 0 && volume <= 100) 
            {
                Console.WriteLine($"Volume is changed to: {volume}");
            }
            else
            {
                Console.WriteLine("The volume must be into range 0 to 100");
            }
        }
    }
}
