using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAbstractFactory
{
    public class Engine<TFactory> : IProduct<TFactory>
    {
        public void Operate()
        {
            Console.WriteLine("Operating Engine.");
        }

        public void EngineSpecificOperation()
        {
            Console.WriteLine("Performing Engine-specific operation.");
        }
    }
}
