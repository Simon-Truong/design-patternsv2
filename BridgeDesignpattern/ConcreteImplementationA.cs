using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignpattern
{
    public class ConcreteImplementationA : IImplementation
    {
        public void Operate()
        {
            Console.WriteLine("A: Operating...");
        }
    }
}
