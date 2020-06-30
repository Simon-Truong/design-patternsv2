using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern
{
    public class Character
    {
        protected IWeaponBehaviour WeaponBehaviour { get; set; }

        public void ChangeWeapon(IWeaponBehaviour weaponBehaviour)
        {
            WeaponBehaviour = weaponBehaviour;
        }

        public void UseWeapon()
        {
            WeaponBehaviour.UseWeapon();
        }
    }
}
