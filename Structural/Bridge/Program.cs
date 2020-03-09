using Bridge.Concrete;

namespace Bridge
{
    class Program
    {
        static void Main()
        {
            var abstraction = new RefinedAbstraction(new ImplementorA());
            abstraction.Operation();
            
            abstraction = new RefinedAbstraction(new ImplementorB());
            abstraction.Operation();
        }
    }
}