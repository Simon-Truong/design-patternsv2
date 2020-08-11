using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern
{
    public class SubtractionHandler : Handler
    {
        public override void Handle(Calculation calculation)
        {
            if (calculation.Operator == Operators.subtraction)
            {
                Console.WriteLine($"{calculation.Number1} - {calculation.Number2} = {calculation.Number1 - calculation.Number2}");
            }

            if (handler != null)
            {
                handler.Handle(calculation);
            }
        }
    }
}
