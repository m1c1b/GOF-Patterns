namespace Abstract_Factory
{
    class Client
    {
        private AbstractProductA.AbstractProductA _abstractProductA;
        private AbstractProductB.AbstractProductB _abstractProductB;

        public Client(AbstractFactory.AbstractFactory factory)
        {
            _abstractProductA = factory.CreateProductA();
            _abstractProductB = factory.CreateProductB();
        }

        public void Run()
        {
            _abstractProductB.Interact(_abstractProductA);
        }
    }
}
