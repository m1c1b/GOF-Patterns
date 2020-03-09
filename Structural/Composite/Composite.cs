using System;
using System.Collections;

namespace Composite
{
    public class Composite : Component
    {
        private ArrayList Nodes { get; } = new ArrayList();

        public Composite(string name) : base(name)
        {
        }

        public override void Operation()
        {
            Console.WriteLine(Name);

            foreach (Component component in Nodes)
                component.Operation();
        }

        public override void Add(Component component)
        {
            Nodes.Add(component);
        }

        public override void Remove(Component component)
        {
            Nodes.Remove(component);
        }

        public override Component GetChild(int index)
        {
            return Nodes[index] as Component;
        }
    }
}