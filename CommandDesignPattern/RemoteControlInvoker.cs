using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
    public class RemoteControlInvoker
    {
        private readonly ICommand[] Commands = new ICommand[7];
        private ICommand LastCommand;

        public RemoteControlInvoker()
        {
            for (int i = 0; i < 7; i++)
            {
                Commands[i] = new NullObjectCommand();
            }
        }

        public void SetCommand(int index, ICommand command)
        {
            Commands[index] = command;
        }

        public void PressOn(int index)
        {
            ICommand command = Commands[index];
            LastCommand = command;
            command.Execute();
        }

        public void PressUndo()
        {
            LastCommand.Undo();
        }
    }
}
