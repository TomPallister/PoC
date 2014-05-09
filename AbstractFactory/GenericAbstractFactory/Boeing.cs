using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAbstractFactory
{
    public class Boeing : IProduct<Plane>
    {
        public void Operate()
        {
            Console.WriteLine("Flying Boeing.");
        }

        public void BoeingSpecificOperation()
        {
            Console.WriteLine("Performing Boeing-specific operation.");
        }
    }
}
