using System;
using System.Collections.Generic;
using System.Text;

namespace MementoDesignPattern
{
    public class Originator
    {
        public string State { get; set; }

        public void SetState(string state)
        {
            State = state;
        }

        public Memento CreateMemento()
        {
            return new Memento(State);
        }

        public void RestoreFromMemento(Memento memento)
        {
            State = memento.State;
        }
    }
}
