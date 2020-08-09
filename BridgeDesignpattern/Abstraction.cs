using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignpattern
{
    public abstract class Abstraction
    {
        private readonly IImplementation implementation;

        public Abstraction(IImplementation implementation)
        {
            this.implementation = implementation;
        }

        public virtual void Operate()
        {
            implementation.Operate();
        }
    }
}
