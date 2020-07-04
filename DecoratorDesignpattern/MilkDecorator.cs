using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignpattern
{
    public class MilkDecorator : Decorator
    {
        public MilkDecorator(IBeverage beverage) : base(beverage)
        {
        }

        public override float GetCost()
        {
            return _beverage.GetCost() + 1.0f;
        }

        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()} + \"milk\"";
        }
    }
}
