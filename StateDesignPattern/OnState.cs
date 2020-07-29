using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPattern
{
    public class OnState : IState
    {
        private readonly Toaster toaster;

        public OnState(Toaster toaster)
        {
            this.toaster = toaster;
        }

        public void InsertBread()
        {
            Console.WriteLine("Bread is inserted");
            toaster.SetState(toaster.readyState);
        }

        public void PressLever()
        {
            Console.WriteLine("You need to insert bread first");
        }

        public void RemoveToast()
        {
            Console.WriteLine("No toast to remove");
        }

        public void SetTimer(int durationInMinutes)
        {
            Console.WriteLine($"Duration has been set to {durationInMinutes} minutes");
        }

        public void TurnOff()
        {
            Console.WriteLine("Switching toaster off");
            toaster.SetState(toaster.offState);
        }

        public void TurnOn()
        {
            Console.WriteLine("Toaster is already on");
        }
    }
}
