using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDesignPattern
{
    public class AdditionVisitor : IVisitor
    {
        public int Visit(CustomExpression exp)
        {
            return exp.Number1 + exp.Number2;
        }
    }
}
