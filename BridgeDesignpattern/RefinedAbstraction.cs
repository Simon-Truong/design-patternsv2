using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignpattern
{
    public class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(IImplementation implementation) : base(implementation)
        {
        }
    }
}
