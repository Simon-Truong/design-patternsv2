using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public class ConcreteColleague : IColleague
    {
        private readonly string name;

        public ConcreteColleague(string name)
        {
            this.name = name;
        }

        public void Receive(string message)
        {
            Console.WriteLine($"Colleague{name} received: {message}");
        }
    }
}
