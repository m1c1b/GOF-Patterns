using Abstract_Factory.AbstractFactory;

namespace Abstract_Factory
{
    class Program
    {
        static void Main()
        {
            var client = new Client(new ConcreteFactory1());
            client.Run();

            client = new Client(new ConcreteFactory2());
            client.Run();
            
        }
    }
}