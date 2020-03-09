using Factory_method.Product;

namespace Factory_method.Creator
{
    class ConcreteCreator : Creator
    {
        public override Product.Product FactoryMethod()
        {
            return new ConcreteProduct();
        }
    }
}
