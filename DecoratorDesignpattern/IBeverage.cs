using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignpattern
{
    public interface IBeverage
    {
        public string GetDescription();
        public float GetCost();
    }
}
