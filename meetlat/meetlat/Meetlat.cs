using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meetlat
{
class Meetlatje
    {
        public Meetlatje(double LengteM, double LengteCm)
        {
            Meter = LengteM;
            Centimeter = LengteCm;
            Voet = LengteM*3.2808;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"uw lengte is {Meter} meter, dat is {Voet} voet");
        }

        public double Meter;
        public double Centimeter;
        public double Voet;

    }

}
