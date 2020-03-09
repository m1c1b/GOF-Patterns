namespace Chain_of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var handler1 = new ConcreteHandler1();
            var handler2 = new ConcreteHandler2();

            handler1.Successor = handler2;
            
            handler1.HandleRequest(1);
            handler1.HandleRequest(2);
        }
    }
}