using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPattern
{
    public class OffState : IState
    {
        private readonly Toaster toaster;

        public OffState(Toaster toaster)
        {
            this.toaster = toaster;
        }

        public void InsertBread()
        {
            Console.WriteLine("Cannot insert bread to an appliance that is off");
        }

        public void PressLever()
        {
            Console.WriteLine("Can only press lever if appliance is on and bread is inserted");
        }

        public void RemoveToast()
        {
            Console.WriteLine("Cannot remove toast because there is no bread");
        }

        public void SetTimer(int durationInMinutes)
        {
            Console.WriteLine($"Duration has been set to {durationInMinutes} minutes");
        }

        public void TurnOff()
        {
            Console.WriteLine("Appliance is already off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Appliance is switched on");
            toaster.SetState(toaster.onState);
        }
    }
}
