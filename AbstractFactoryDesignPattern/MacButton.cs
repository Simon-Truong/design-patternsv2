using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    public class MacButton : Button
    {
        public MacButton()
        {
            Colour = "Mac colour";
            Behaviour = "Mac behaviour";
        }
    }
}
