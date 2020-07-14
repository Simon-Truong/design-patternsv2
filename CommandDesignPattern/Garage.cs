using System;

namespace CommandDesignPattern
{
    public class Garage : IGarage
    {
        public void CloseGarage()
        {
            Console.WriteLine("Closing garage");
        }

        public void OpenGarage()
        {
            Console.WriteLine("Opening garage");
        }
    }
}
