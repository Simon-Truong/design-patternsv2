using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    public abstract class Builder
    {
        public Robot Robot { get; }

        public Builder(string name)
        {
            Robot = new Robot(name);
        }

        public Builder SetHead(string material)
        {
            Robot.Head = material;
            return this;
        }

        public Builder SetBody(string material)
        {
            Robot.Body = material;
            return this;
        }

        public Builder SetLimbs(string material)
        {
            Robot.Limbs = material;
            return this;
        }

        public Builder SetManual(bool isManual)
        {
            Robot.Manual = isManual;
            return this;
        }

        public Robot Build()
        {
            return Robot;
        }
    }
}
