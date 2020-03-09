using Factory_method.Creator;

namespace Factory_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Product.Product product = null;

            var creator = new ConcreteCreator();
            product = creator.FactoryMethod();

            creator.AnOperation();
        }
    }
}