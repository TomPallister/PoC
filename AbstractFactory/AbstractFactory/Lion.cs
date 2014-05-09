using System;

namespace AbstractFactory
{
    public class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Wildebeest
            Console.WriteLine(GetType().Name +
                              " eats " + h.GetType().Name);
        }
    }
}