using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AbstractFactory.Tests
{
    public class Tests
    {
        [Fact]
        public void FirstTest()
        {
            ContinentFactory africa = new AfricaFactory();
            var world = new AnimalWorld(africa);
            world.RunFoodChain();

            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();
        }
    }
}
