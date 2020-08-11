using System;

namespace FlyweightDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FlyweightFactory flyweightFactory = new FlyweightFactory();

            IFlyweight flyweight1 = flyweightFactory.GetFlyweight("a");
            IFlyweight flyweight2 = flyweightFactory.GetFlyweight("b");
            IFlyweight existingFlyweight = flyweightFactory.GetFlyweight("a");

            flyweight1.Display();
            flyweight2.Display();
            existingFlyweight.Display();

            Console.ReadLine();
        }
    }
}
