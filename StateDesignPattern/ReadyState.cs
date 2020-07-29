using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPattern
{
    public class ReadyState : IState
    {
        private readonly Toaster toaster;

        public ReadyState(Toaster toaster)
        {
            this.toaster = toaster;
        }

        public void InsertBread()
        {
            Console.WriteLine("Bread is already inserted");
        }

        public void PressLever()
        {
            Console.WriteLine("Begin toasting bread");
            toaster.SetState(toaster.finishedState);
        }

        public void RemoveToast()
        {
            Console.WriteLine("Bread are removed");
            toaster.SetState(toaster.onState);
        }

        public void SetTimer(int durationInMinutes)
        {
            Console.WriteLine($"Duration has been set to {durationInMinutes} minutes");
        }

        public void TurnOff()
        {
            Console.WriteLine("Remove bread first");
        }

        public void TurnOn()
        {
            Console.WriteLine("Toaster is already on");
        }
    }
}
