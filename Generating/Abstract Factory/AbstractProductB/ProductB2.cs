using System;

namespace Abstract_Factory.AbstractProductB
{
    class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA.AbstractProductA apa)
        {
            Console.WriteLine(this + " interacts with " + apa);
        }
    }
}
