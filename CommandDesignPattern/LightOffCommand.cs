using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
    public class LightOffCommand : ICommand
    {
        private readonly ILight Light;

        public LightOffCommand(ILight light)
        {
            Light = light;
        }

        public void Execute()
        {
            Light.LightOff();
        }

        public void Undo()
        {
            Light.LightOn();
        }
    }
}
