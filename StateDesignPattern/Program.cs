using System;

namespace StateDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Toaster toaster = new Toaster();

            toaster.TurnOff();

            toaster.TurnOn();
            toaster.TurnOff();
            toaster.TurnOff();

            toaster.TurnOn();
            toaster.InsertBread();
            toaster.PressLever();
            toaster.RemoveToast();

            toaster.TurnOn();
            toaster.InsertBread();
            toaster.RemoveToast();

            Console.ReadLine();
        }
    }
}
