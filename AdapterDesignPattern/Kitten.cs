using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern
{
    public class Kitten : ICat
    {
        public void Meow()
        {
            Console.WriteLine("Kitten meows");
        }

        public void Walk()
        {
            Console.WriteLine("Kitten walks");
        }
    }
}
