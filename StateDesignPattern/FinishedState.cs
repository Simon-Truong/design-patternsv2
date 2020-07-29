using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPattern
{
    public class FinishedState : IState
    {
        private readonly Toaster toaster;

        public FinishedState(Toaster toaster)
        {
            this.toaster = toaster;
        }

        public void InsertBread()
        {
            Console.WriteLine("Remove toasts first");
        }

        public void PressLever()
        {
            Console.WriteLine("Remove toasts first");
        }

        public void RemoveToast()
        {
            Console.WriteLine("Toasts are removed");
            toaster.SetState(toaster.onState);
        }

        public void SetTimer(int durationInMinutes)
        {
            Console.WriteLine($"Duration has been set to {durationInMinutes} minutes");
        }

        public void TurnOff()
        {
            Console.WriteLine("Remove toasts first");
        }

        public void TurnOn()
        {
            Console.WriteLine("Toaster is already on");
        }
    }
}
