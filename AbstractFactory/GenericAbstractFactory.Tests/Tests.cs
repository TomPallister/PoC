using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GenericAbstractFactory.Tests
{
    public class Tests
    {
        [Fact]
        public void FirstTest()
        {
            var carFactory = new Factory<Car>();
            var planeFactory = new Factory<Plane>();
            IProduct<Car> carProduct = carFactory.Create<Toyota>();
            IProduct<Plane> planeProduct = planeFactory.Create<Boeing>();
            carProduct.Operate();
            planeProduct.Operate();

            carProduct = carFactory.Create<Engine<Car>>();
            carProduct.Operate();
        }
    }
}
