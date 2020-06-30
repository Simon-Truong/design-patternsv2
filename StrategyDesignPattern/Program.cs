using System;

namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Character knight = new Knight();
            knight.UseWeapon();
            knight.ChangeWeapon(new AxeBehaviour());
            knight.UseWeapon();
            Console.ReadLine();
        }
    }
}
