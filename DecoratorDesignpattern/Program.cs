using System;

namespace DecoratorDesignpattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IBeverage mocha = new Mocha();

            mocha = new MilkDecorator(mocha);
            mocha = new SugarDecorator(mocha);
            mocha = new MilkDecorator(mocha);

            Console.WriteLine(mocha.GetCost());
            Console.WriteLine(mocha.GetDescription());

            Console.ReadLine();
        }
    }
}
