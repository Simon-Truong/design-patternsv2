using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public interface IPetStore
    {
        // this is now redundant as we do not want to expose the underlying collection
        //public T GetPets();
        public IIterator CreateIterator();
    }
}
