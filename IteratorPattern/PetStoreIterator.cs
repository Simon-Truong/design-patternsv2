using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public class PetStoreIterator : IIterator
    {
        private readonly IPet[] _pets;
        private int position = 0;

        public PetStoreIterator(IPet[] pets)
        {
            _pets = pets;
        }

        public bool HasNext()
        {
            if (position >= _pets.Length)
            {
                return false;
            }

            return true;
        }

        public IPet Next()
        {
            IPet pet = _pets[position];
            position++;
            return pet;
        }
    }
}
