using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAbstractFactory
{
    public class Car : IFactory<Car>
    {
        public TProduct Build<TProduct>() where TProduct : IProduct<Car>, new()
        {
            Console.WriteLine("Creating Car: " + typeof(TProduct));
            return new TProduct();
        }
    }
}
