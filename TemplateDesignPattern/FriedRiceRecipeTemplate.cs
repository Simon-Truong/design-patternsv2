using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TemplateDesignPattern
{
    public abstract class FriedRiceRecipeTemplate : ITemplate
    {
        public void CookFriedRice()
        {
            CookRice();
            AddSoyaSauce();
            AddVegetables();

            if (!Vegetarian())
            {
                AddMeat();
            }

            if (LactoseTolerant())
            {
                AddEgg();
            }
        }

        public abstract void CookRice();

        public void AddSoyaSauce()
        {
            Console.WriteLine("Adding soya sauce");
        }

        public abstract void AddVegetables();

        public abstract void AddMeat();

        public void AddEgg()
        {
            Console.WriteLine("Adding egg");
        }

        public virtual bool LactoseTolerant()
        {
            return true;
        }

        public virtual bool Vegetarian()
        {
            return false;
        }
    }
}
