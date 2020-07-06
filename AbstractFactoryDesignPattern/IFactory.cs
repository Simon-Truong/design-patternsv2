using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    public interface IFactory
    {
        public Cursor GetCursor();
        public Button GetButton();
    }
}
