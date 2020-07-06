using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    public class AppleFactory : IFactory
    {
        public Button GetButton()
        {
            return new MacButton();
        }

        public Cursor GetCursor()
        {
            return new MacCursor();
        }
    }
}
