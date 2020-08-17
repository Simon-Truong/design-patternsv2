using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDesignPattern
{
    public class MultiplicationVisitor : IVisitor
    {
        public int Visit(CustomExpression exp)
        {
            return exp.Number1 * exp.Number2;
        }
    }
}
