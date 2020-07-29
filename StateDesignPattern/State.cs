using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPattern
{
    public interface IState
    {
        public void TurnOn();
        public void TurnOff();
        public void SetTimer(int durationInMinutes);
        public void InsertBread();
        public void RemoveToast();
        public void PressLever();
    }
}
