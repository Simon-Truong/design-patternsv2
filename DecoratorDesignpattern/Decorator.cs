using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignpattern
{
    public abstract class Decorator : IBeverage
    {
        protected readonly IBeverage _beverage;

        public Decorator(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public abstract float GetCost();

        public abstract string GetDescription();
    }
}
