using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDesignPattern
{
    public class Address : ICloneable<Address>
    {
        public int Number { get; set; }
        public string Street { get; set; }
        public string Suburb{ get; set; }

        public Address DeepClone()
        {
            return (Address)this.MemberwiseClone();
        }

        public Address ShallowClone()
        {
            return (Address)this.MemberwiseClone();
        }
    }
}
