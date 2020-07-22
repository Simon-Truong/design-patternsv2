using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public interface IIterator
    {
        public bool HasNext();
        public IPet Next();
    }
}
