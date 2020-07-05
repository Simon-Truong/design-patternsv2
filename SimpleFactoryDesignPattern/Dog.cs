using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryDesignPattern
{
    public class Dog : IAnimal
    {
        public void eat()
        {
            Console.WriteLine("Dog is eating");
        }

        public void sleep()
        {
            Console.WriteLine("Dog is sleeping");
        }
    }
}
