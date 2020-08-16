using System;

namespace MementoDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();

            originator.SetState("Beginner");
            Console.WriteLine(originator.State);

            CareTaker careTaker = new CareTaker();

            careTaker.AddMemento(originator.CreateMemento());

            originator.SetState("Intermediate");
            Console.WriteLine(originator.State);

            originator.RestoreFromMemento(careTaker.GetMemento(0));
            Console.WriteLine(originator.State);

            Console.ReadLine();
        }
    }
}
