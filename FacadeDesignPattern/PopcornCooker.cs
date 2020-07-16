using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern
{
    public class PopcornCooker
    {
        public void CookPopcorn()
        {
            Console.WriteLine("Cooking popcorn");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turn on popcorn cooker");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turn off popcorn cooker");
        }
    }
}
