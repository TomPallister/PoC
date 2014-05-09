using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAbstractFactory
{
    public class Plane : IFactory<Plane>
    {
        public TProduct Build<TProduct>() where TProduct : IProduct<Plane>, new()
        {
            Console.WriteLine("Creating Plane: " + typeof(TProduct));
            return new TProduct();
        }
    }
}
