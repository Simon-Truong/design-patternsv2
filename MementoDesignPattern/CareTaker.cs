using System;
using System.Collections.Generic;
using System.Text;

namespace MementoDesignPattern
{
    public class CareTaker
    {
        public readonly List<Memento> SavedStates = new List<Memento>();

        public void AddMemento(Memento memento)
        {
            SavedStates.Add(memento);
        }

        public Memento GetMemento(int index)
        {
            return SavedStates[index];
        }
    }
}
