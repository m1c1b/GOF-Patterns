namespace Factory_method.Creator
{   
    abstract class Creator
    {
        Product.Product _product;

        public abstract Product.Product FactoryMethod();

        public void AnOperation()
        {
            _product = FactoryMethod();
        }
    }
}
