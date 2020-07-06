using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    public class WindowsFactory : IFactory
    {
        public Button GetButton()
        {
            return new WindowsButton();
        }

        public Cursor GetCursor()
        {
            return new WindowsCursor();
        }
    }
}
