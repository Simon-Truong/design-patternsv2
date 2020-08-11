using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern
{
    public class Calculation
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public Operators Operator { get; set; }
    }

    public enum Operators
    {
        addition,
        subtraction,
        multiplication,
        division
    }
}
