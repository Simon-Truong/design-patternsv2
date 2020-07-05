using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryDesignPattern
{
    public class Cat : IAnimal
    {
        public void eat()
        {
            Console.WriteLine("Cat is eating");
        }

        public void sleep()
        {
            Console.WriteLine("Cat is sleeping");
        }
    }
}
