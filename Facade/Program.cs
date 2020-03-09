namespace Facade
{
    class Program
    {
        static void Main()
        {
            var facade = new Facade();
            
            facade.MethodA();
            facade.MethodB();
        }
    }
}