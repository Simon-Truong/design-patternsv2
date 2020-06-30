using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern
{
    public class Knight : Character
    {
        public Knight()
        {
            WeaponBehaviour = new SwordBehaviour();
        }
    }
}
