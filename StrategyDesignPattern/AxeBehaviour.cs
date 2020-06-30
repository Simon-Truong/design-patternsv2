using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern
{
    public class AxeBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Using axe");
        }
    }
}
