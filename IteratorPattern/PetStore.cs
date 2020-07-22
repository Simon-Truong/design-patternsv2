using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public class PetStore : IPetStore
    {
        private readonly IPet[] _pets;

        public PetStore(IPet[] pets)
        {
            _pets = pets;
        }

        public IIterator CreateIterator()
        {
            return new PetStoreIterator(_pets);
        }

        // this is now redundant
        //public IPet[] GetPets()
        //{
        //    return _pets;
        //}
    }
}
