using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandDesignPattern
{
    public class MacroCommand : ICommand
    {
        private readonly ICommand[] Commands;

        public MacroCommand(ICommand[] commands)
        {
            Commands = commands;
        }

        public void Execute()
        {
            foreach (ICommand command in Commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            for (int i = Commands.Count() - 1; i >= 0; i--)
            {
                Commands[i].Undo();
            }
        }
    }
}
