using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern
{
    public abstract class Handler
    {
        protected Handler handler { get; set; }

        public void SetNextHandler(Handler handler)
        {
            this.handler = handler;
        }

        public abstract void Handle(Calculation calculation);
    }
}
