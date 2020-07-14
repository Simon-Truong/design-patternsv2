using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
    public interface ICommand
    {
        public void Execute();
        public void Undo();
    }
}
