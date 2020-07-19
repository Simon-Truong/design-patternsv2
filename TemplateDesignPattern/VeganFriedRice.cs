using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateDesignPattern
{
    public class VeganFriedRice : FriedRiceRecipeTemplate
    {
        public override void AddMeat()
        {
            throw new NotImplementedException();
        }

        public override void AddVegetables()
        {
            Console.WriteLine("Adding kale, cabbage, peas and carrot");
        }

        public override void CookRice()
        {
            Console.WriteLine("Cooking basmati rice");
        }

        public override bool LactoseTolerant()
        {
            return false;
        }

        public override bool Vegetarian()
        {
            return true;
        }
    }
}
