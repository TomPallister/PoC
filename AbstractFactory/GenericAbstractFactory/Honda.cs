using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAbstractFactory
{
    public class Honda : IProduct<Car>
    {
        public void Operate()
        {
            Console.WriteLine("Driving Honda.");
        }

        public void HondaSpecificOperation()
        {
            Console.WriteLine("Performing Honda-specific operation.");
        }
    }
}
