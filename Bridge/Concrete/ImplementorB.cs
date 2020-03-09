using System;
using Bridge.Abstractions;

namespace Bridge.Concrete
{
    public class ImplementorB : Implementor
    {
        public override void OperationImplementation()
        {
            Console.WriteLine("Real Implementation B");
        }
    }
}