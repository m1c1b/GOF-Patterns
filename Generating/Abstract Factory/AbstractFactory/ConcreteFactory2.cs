using Abstract_Factory.AbstractProductA;
using Abstract_Factory.AbstractProductB;

namespace Abstract_Factory.AbstractFactory
{
    class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA.AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB.AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
