using System;

namespace Factory_method.Product
{
    sealed class ConcreteProduct : Product
    {
        public ConcreteProduct()
        {
            Console.WriteLine(GetHashCode());
        }
    }
}
