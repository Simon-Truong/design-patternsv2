using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignpattern
{
    public class ConcreteImplementationB : IImplementation
    {
        public void Operate()
        {
            Console.WriteLine("B: Operating...");
        }
    }
}
