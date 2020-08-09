using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    public class RobotBuilder : Builder
    {
        public RobotBuilder(string name) : base(name)
        {
        }
    }
}
