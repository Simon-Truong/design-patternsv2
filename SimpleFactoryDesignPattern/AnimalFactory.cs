using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace SimpleFactoryDesignPattern
{
   public static class AnimalFactory
    {
        public static IAnimal CreateAnimal(string type)
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
