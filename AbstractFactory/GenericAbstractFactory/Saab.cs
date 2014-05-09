using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAbstractFactory
{
    public class Saab : IProduct<Car>, IProduct<Plane>
    {
        public void Operate()
        {
            Console.WriteLine("Operating Saab.");
        }

        public void SaabSpecificOperation()
        {
            Console.WriteLine("Performing Saab-specific operation.");
        }
    }
}
