using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern
{
    public interface IFactory
    {
        public IAnimal CreateAnimal(string type);
    }
}
