using System;

namespace Template_method
{
    public class ConcreteClass: AbstractClass
    {
        protected override void Operation1()
        {
            Console.WriteLine("PrimitiveOperation1");
        }

        protected override void Operation2()
        {
            Console.WriteLine("PrimitiveOperation2");
        }
    }
}