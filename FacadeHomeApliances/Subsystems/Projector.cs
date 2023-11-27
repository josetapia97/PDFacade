using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeHomeApliances.Subsystems
{
    public class Projector
    {
        public void On()
        {
            Console.WriteLine("Projector turned on");
        }
        public void Off()
        {
            Console.WriteLine("Projector turned off");
        }

        public void AdjustResolution()
        {
            Console.WriteLine("Resolution is changed");
        }
    }
}
