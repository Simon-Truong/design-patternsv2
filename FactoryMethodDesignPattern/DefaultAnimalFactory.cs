using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern
{
    public class DefaultAnimalFactory : IFactory
    {
        public IAnimal CreateAnimal(string type)
        {
            return Create(type);
        }

        /* 
         * can make this a virtual method, where IFactory is an abstract class so we can re-use this
         * therefore anything that inherits the abstract class will only need to worry about implementing CreateAnimal()
         */
        private IAnimal Create(string type)
        {
            return type switch
            {
                "dog" => new Dog(),
                "cat" => new Cat(),
                "duck" => new Duck(),
                _ => throw new ArgumentException("Animal type does not exist")
            };
        }
    }
}
