using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignpattern
{
    public class SugarDecorator : Decorator
    {
        public SugarDecorator(IBeverage beverage) : base(beverage)
        {
        }

        public override float GetCost()
        {
            return _beverage.GetCost() + 0.5f;
        }

        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()} + \"sugar\"";
        }
    }
}
