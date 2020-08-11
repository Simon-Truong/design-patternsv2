using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightDesignPattern
{
    public class Flyweight : IFlyweight
    {
        private readonly string key;

        public Flyweight(string key)
        {
            this.key = key;
        }

        public void Display()
        {
            Console.WriteLine(key);
        }
    }
}
