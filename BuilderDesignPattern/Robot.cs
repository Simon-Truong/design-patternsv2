using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    public class Robot
    {
        public string Name { get; }
        public string Head { get; set; }
        public string Body { get; set; }
        public string Limbs { get; set; }
        public bool Manual { get; set; }

        public Robot(string name)
        {
            Name = name;
        }
    }
}
