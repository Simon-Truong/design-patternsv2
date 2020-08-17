using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDesignPattern
{
    public interface IVisitor
    {
        public int Visit(CustomExpression exp);
        // you can add multiple method signatures, visiting different types
    }
}
