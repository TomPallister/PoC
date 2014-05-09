using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAbstractFactory
{
    public interface IProduct<TFactory>
    {
        void Operate();
    }
}
