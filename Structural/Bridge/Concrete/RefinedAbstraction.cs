using System;
using Bridge.Abstractions;

namespace Bridge.Concrete
{
    public class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine();
        }

        public RefinedAbstraction(Implementor implementor) : base(implementor)
        {
        }
    }
}