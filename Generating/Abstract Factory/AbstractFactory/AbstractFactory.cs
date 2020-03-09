namespace Abstract_Factory.AbstractFactory
{
    abstract class AbstractFactory
    {
        public abstract AbstractProductA.AbstractProductA CreateProductA();
        public abstract AbstractProductB.AbstractProductB CreateProductB();
    }
}
