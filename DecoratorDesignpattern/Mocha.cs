using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignpattern
{
    public class Mocha : IBeverage
    {
        public float GetCost()
        {
            return 1;
        }

        public string GetDescription()
        {
            return "Mocha";
        }
    }
}
