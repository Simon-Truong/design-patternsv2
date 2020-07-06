using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    public class MacCursor : Cursor
    {
        public MacCursor()
        {
            Colour = "Mac colour";
            Behaviour = "Mac behaviour";
        }
    }
}
