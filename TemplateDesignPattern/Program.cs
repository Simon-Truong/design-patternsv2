using System;

namespace TemplateDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ITemplate chineseFriedRice = new ChineseFriedRice();
            ITemplate veganFriedRice = new VeganFriedRice();

            chineseFriedRice.CookFriedRice();
            veganFriedRice.CookFriedRice();

            Console.ReadLine();
        }
    }
}
