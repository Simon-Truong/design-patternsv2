using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeDesignPattern
{
    public abstract class Component
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public abstract void Print();

        public virtual Component GetChild(int i)
        {
            throw new NotImplementedException();
        }

        public virtual void SetItem(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual void RemoveItem(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
