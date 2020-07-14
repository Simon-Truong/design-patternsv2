using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
    public class Light : ILight
    {
        public void LightOff()
        {
            Console.WriteLine("Turning light off");
        }

        public void LightOn()
        {
            Console.WriteLine("Turning light on");
        }
    }
}
