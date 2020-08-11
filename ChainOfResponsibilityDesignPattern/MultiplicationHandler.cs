using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern
{
    class MultiplicationHandler : Handler
    {
        public override void Handle(Calculation calculation)
        {
            if (calculation.Operator == Operators.multiplication)
            {
                Console.WriteLine($"{calculation.Number1} / {calculation.Number2} = {calculation.Number1 / calculation.Number2}");
            }

            if (handler != null)
            {
                handler.Handle(calculation);
            }
        }
    }
}
