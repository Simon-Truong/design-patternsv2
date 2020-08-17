using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDesignPattern
{
    public interface ICloneable<T>
    {
        public T ShallowClone();
        public T DeepClone();
    }
}
