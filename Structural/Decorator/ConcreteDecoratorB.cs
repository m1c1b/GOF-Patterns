using System;

namespace Decorator
{
    public class ConcreteDecoratorB : Decorator
    {
        public void AddedBehavior() => Console.WriteLine("Behavior");

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Concrete action B");
        }
    }
}