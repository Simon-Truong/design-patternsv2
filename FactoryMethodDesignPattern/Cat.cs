using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern
{
    public class Cat : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Cat is eating");
        }

        public void Sleep()
        {
            Console.WriteLine("Cat is sleeping");
        }
    }
}
