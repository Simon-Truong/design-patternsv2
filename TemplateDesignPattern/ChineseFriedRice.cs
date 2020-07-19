using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateDesignPattern
{
    public class ChineseFriedRice : FriedRiceRecipeTemplate
    {
        public override void AddMeat()
        {
            Console.WriteLine("Adding spam");
        }

        public override void AddVegetables()
        {
            Console.WriteLine("Adding corn, peas and carrots");
        }

        public override void CookRice()
        {
            Console.WriteLine("Adding white rice");
        }

        public override bool LactoseTolerant()
        {
            return true;
        }
    }
}
