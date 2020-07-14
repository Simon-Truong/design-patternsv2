using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
    public class OpenGarageCommand : ICommand
    {
        private readonly IGarage Garage;

        public OpenGarageCommand(IGarage garage)
        {
            Garage = garage;
        }

        public void Execute()
        {
            Garage.OpenGarage();
        }

        public void Undo()
        {
            Garage.CloseGarage();
        }
    }
}
