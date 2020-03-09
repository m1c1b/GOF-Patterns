namespace Proxy
{
    class Program
    {
        static void Main()
        {
            var realSubject = new RealSubject();
            var proxy = new Proxy(realSubject);
            
            proxy.Request();
        }
    }
}