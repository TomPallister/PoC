using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAbstractFactory
{
    public class Factory<TFactory> where TFactory : IFactory<TFactory>, new()
    {
        public TProduct Create<TProduct>() where TProduct : IProduct<TFactory>, new()
        {
            return new TFactory().Build<TProduct>();
        }
    }
}
