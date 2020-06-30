using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern
{
    public class SwordBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Using sword");
        }
    }
}
