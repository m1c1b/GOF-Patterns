using System;
using Bridge.Abstractions;

namespace Bridge.Concrete
{
    public class ImplementorA : Implementor
    {
        public override void OperationImplementation()
        {
            Console.WriteLine("Real Implementation A");
        }
    }
}