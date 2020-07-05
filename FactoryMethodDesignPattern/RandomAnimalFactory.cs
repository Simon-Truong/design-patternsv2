using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern
{
    public class RandomAnimalFactory : IFactory
    {
        private readonly string[] ANIMAL_TYPES = new string[] { "dog", "cat", "duck" };

        public IAnimal CreateAnimal(string _)
        {
            Random random = new Random();
            int index = random.Next(3);

            string type = ANIMAL_TYPES[index];

            return Create(type);
        }

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
