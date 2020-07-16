using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern
{
    public class TV
    {
        public void TurnOn()
        {
            Console.WriteLine("Turn on TV");
        }
        
        public void TurnOff()
        {
            Console.WriteLine("Turn off TV");
        }
    }
}
