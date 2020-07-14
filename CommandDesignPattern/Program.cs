using System;

namespace CommandDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControlInvoker remoteControl = new RemoteControlInvoker();

            ILight light = new Light();
            IGarage garage = new Garage();

            ICommand lightOnCommand = new LightOnCommand(light);
            ICommand lightOffCommand = new LightOffCommand(light);
            ICommand openGarageCommand = new OpenGarageCommand(garage);

            remoteControl.SetCommand(0, lightOnCommand);
            remoteControl.SetCommand(1, lightOffCommand);
            remoteControl.SetCommand(2, openGarageCommand);

            remoteControl.PressOn(0);
            remoteControl.PressOn(1);
            remoteControl.PressUndo();

            remoteControl.PressOn(2);
            remoteControl.PressUndo();

            remoteControl.PressOn(3);

            Console.WriteLine("macro command");

            ICommand macroCommand = new MacroCommand(new ICommand[] { lightOnCommand, lightOffCommand, openGarageCommand });

            remoteControl.SetCommand(3, macroCommand);
            remoteControl.PressOn(3);
            remoteControl.PressUndo();

            Console.ReadLine();
        }
    }
}
