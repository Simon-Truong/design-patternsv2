using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    public abstract class Cursor
    {
        public string Colour { get; set; }
        public string Behaviour { get; set; }
    }
}
