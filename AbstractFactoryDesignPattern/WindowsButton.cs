using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    public class WindowsButton : Button
    {
        public WindowsButton()
        {
            Colour = "Windows colour";
            Behaviour = "Windows button";
        }
    }
}
