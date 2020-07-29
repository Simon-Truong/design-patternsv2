using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPattern
{
    public class Toaster
    {
        public readonly IState offState;
        public readonly IState onState;
        public readonly IState readyState;
        public readonly IState finishedState;

        public IState State;

        public Toaster()
        {
            offState = new OffState(this);
            onState = new OnState(this);
            readyState = new ReadyState(this);
            finishedState = new FinishedState(this);

            State = offState;
        }

        public void TurnOn()
        {
            State.TurnOn();
        }

        public void TurnOff()
        {
            State.TurnOff();
        }

        public void SetTimer(int durationInMinutes)
        {
            State.SetTimer(durationInMinutes);
        }

        public void InsertBread()
        {
            State.InsertBread();
        }

        public void RemoveToast()
        {
            State.RemoveToast();
        }

        public void PressLever()
        {
            State.PressLever();
        }

        public void SetState(IState state)
        {
            State = state;
        }
    }
}
