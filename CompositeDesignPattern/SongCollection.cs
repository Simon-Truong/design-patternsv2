using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeDesignPattern
{
    public class SongCollection : Component
    {
        private readonly List<Component> _components = new List<Component>();

        public SongCollection(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override Component GetChild(int i)
        {
            return _components[i];
        }

        public override void SetItem(Component component)
        {
            _components.Add(component);
        }

        public override void RemoveItem(Component component)
        {
            _components.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine($"{Name} - {Description}");

            foreach (Component component in _components)
            {
                component.Print();
            }
        }
    }
}
