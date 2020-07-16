using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern
{
    public class Lion : IBigCat
    {
        public void Roar()
        {
            Console.WriteLine("Lion roars");
        }

        public void Sprint()
        {
            Console.WriteLine("Lion sprints");
        }
    }
}
