using System;

namespace BridgeDesignpattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IImplementation implementationA = new ConcreteImplementationA();
            IImplementation implementationB = new ConcreteImplementationB();

            Abstraction refinedAbstraction = new RefinedAbstraction(implementationA);
            refinedAbstraction.Operate();

            refinedAbstraction = new RefinedAbstraction(implementationB);
            refinedAbstraction.Operate();

            Console.ReadLine();
        }
    }
}
