using System;

namespace Composite
{
    /// <summary>
    /// Leaf is the component that never has a child
    /// </summary>
    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Operation()
        {
            Console.WriteLine(Name);
        }

        public override void Add(Component component)
        {
            throw new InvalidOperationException("This is a leaf.");
        }

        public override void Remove(Component component)
        {
            throw new InvalidOperationException("This is a leaf.");

        }

        public override Component GetChild(int index)
        {
            throw new InvalidOperationException("This is a leaf.");
        }
    }
}