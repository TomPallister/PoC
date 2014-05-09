using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAbstractFactory
{
    class Rudder : IProduct<Plane>
    {
        public void Operate()
        {
            Console.WriteLine("Operating Rudder.");
        }

        public void RudderSpecificOperation()
        {
            Console.WriteLine("Performing Rudder-specific operation.");
        }
    }
}
