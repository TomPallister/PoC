using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAbstractFactory
{
    public interface IFactory<TFactory>
    {
        TProduct Build<TProduct>() where TProduct : IProduct<TFactory>, new();
    } 
}
