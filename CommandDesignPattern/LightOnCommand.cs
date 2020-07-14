using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
    public class LightOnCommand : ICommand
    {
        private readonly ILight Light;

        public LightOnCommand(ILight light)
        {
            Light = light;
        }

        public void Execute()
        {
            Light.LightOn();
        }

        public void Undo()
        {
            Light.LightOff();
        }
    }
}
