using System.Threading;

namespace Command
{
    class Program
    {
        static void Main()
        {
            var receiver = new Receiver();
            var command1 = new ConcreteCommand(receiver);
            var invoker = new Invoker();
            
            invoker.SetCommand(command1);
            Thread.Sleep(50);
            
            invoker.ExecuteCommand();
        }
    }
}