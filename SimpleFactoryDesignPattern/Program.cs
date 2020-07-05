using System;

namespace SimpleFactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal dog = AnimalFactory.CreateAnimal("dog");
            IAnimal cat = AnimalFactory.CreateAnimal("cat");
            IAnimal duck = AnimalFactory.CreateAnimal("duck");

            dog.eat();
            dog.sleep();

            cat.eat();
            cat.sleep();

            duck.eat();
            duck.sleep();

            Console.ReadLine();
        }
    }
}
