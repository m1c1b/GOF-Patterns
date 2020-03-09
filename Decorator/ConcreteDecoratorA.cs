using System;

namespace Decorator
{
    public class ConcreteDecoratorA : Decorator
    {
        public string AddedState = "Some State A";
        public override void Operation()
        {
            base.Operation();
            
            Console.WriteLine(AddedState);
        }
    }
}