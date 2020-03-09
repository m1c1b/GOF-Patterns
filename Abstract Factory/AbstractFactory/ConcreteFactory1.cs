using Abstract_Factory.AbstractProductA;
using Abstract_Factory.AbstractProductB;

namespace Abstract_Factory.AbstractFactory
{
    class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA.AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB.AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
