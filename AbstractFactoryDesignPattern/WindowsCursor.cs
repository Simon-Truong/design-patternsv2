using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    public class WindowsCursor : Cursor
    {
        public WindowsCursor()
        {
            Colour = "Windows colour";
            Behaviour = "Windows behaviour";
        }
    }
}
