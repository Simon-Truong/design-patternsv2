using System;

namespace ChainOfResponsibilityDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler additionHandler = new AdditionHandler();
            Handler subtractionHandler = new SubtractionHandler();
            Handler multiplicationHandler = new MultiplicationHandler();
            Handler divisionHandler = new DivisionHandler();

            additionHandler.SetNextHandler(subtractionHandler);
            subtractionHandler.SetNextHandler(multiplicationHandler);
            multiplicationHandler.SetNextHandler(divisionHandler);

            Calculation calculation = new Calculation
            {
                Number1 = 10,
                Number2 = 5,
                Operator = Operators.subtraction
            };

            additionHandler.Handle(calculation);

            Console.ReadLine();
        }
    }
}
