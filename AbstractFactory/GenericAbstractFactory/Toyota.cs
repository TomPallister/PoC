using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAbstractFactory
{
    public class Toyota : IProduct<Car>
    {
        public void Operate()
        {
            Console.WriteLine("Driving Toyota.");
        }

        public void ToyotaSpecificOperation()
        {
            Console.WriteLine("Performing Toyota-specific operation.");
        }
    }
}
