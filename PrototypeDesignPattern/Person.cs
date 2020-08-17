using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDesignPattern
{
    public class Person : ICloneable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }

        public Person DeepClone()
        {
            Person clone = (Person)this.MemberwiseClone();
            clone.Address = Address.ShallowClone();

            return clone;
        }

        public Person ShallowClone()
        {
            return (Person)this.MemberwiseClone();
        }
    }
}
