using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDesignPattern
{
    public class CustomExpression
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        public int Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
