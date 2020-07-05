using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryDesignPattern
{
    public class Duck : IAnimal
    {
        public void eat()
        {
            Console.WriteLine("Duck is eating");
        }

        public void sleep()
        {
            Console.WriteLine("Duck is sleeping");
        }
    }
}
