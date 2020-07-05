using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern
{
    public class Dog : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Dog is eating");
        }

        public void Sleep()
        {
            Console.WriteLine("Dog is sleeping");
        }
    }
}
