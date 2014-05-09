using System;

namespace AbstractFactory
{
    public class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Bison
            Console.WriteLine(GetType().Name +
                              " eats " + h.GetType().Name);
        }
    }
}