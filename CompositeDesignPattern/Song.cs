using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeDesignPattern
{
    public class Song : Component
    {
        public Song(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override void Print()
        {
            Console.WriteLine($"{Name} - {Description}");
        }
    }
}
