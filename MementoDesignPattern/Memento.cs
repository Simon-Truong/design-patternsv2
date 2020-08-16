using System;
using System.Collections.Generic;
using System.Text;

namespace MementoDesignPattern
{
    public class Memento
    {
        public string State { get; set; }

        public Memento(string state)
        {
            this.State = state;
        }
    }
}
