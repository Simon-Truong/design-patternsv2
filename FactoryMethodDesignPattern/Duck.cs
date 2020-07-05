using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern
{
    public class Duck : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Duck is eating");
        }

        public void Sleep()
        {
            Console.WriteLine("Duck is sleeping");
        }
    }
}
