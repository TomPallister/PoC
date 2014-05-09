using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAbstractFactory
{
    class Frame<TFactory> : IProduct<Car>, IProduct<Plane>
    {
        public void Operate()
        {
            Console.WriteLine("Operating Frame.");
        }

        public void FrameSpecificOperation()
        {
            Console.WriteLine("Performing Frame-specific operation.");
        }
    }
}
