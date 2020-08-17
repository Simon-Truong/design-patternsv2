using System;

namespace VisitorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomExpression exp = new CustomExpression { Number1 = 5, Number2 = 2 };

            IVisitor additionVisitor = new AdditionVisitor();
            IVisitor multiplicationVisitor = new MultiplicationVisitor();

            Console.WriteLine(exp.Accept(additionVisitor));
            Console.WriteLine(exp.Accept(multiplicationVisitor));

            Console.ReadLine();
        }
    }
}
