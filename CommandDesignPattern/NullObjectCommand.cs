using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
    public class NullObjectCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Do nothing for execute");
        }

        public void Undo()
        {
            Console.WriteLine("Do nothing for undo");
        }
    }
}
