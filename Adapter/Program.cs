using System;

namespace Adapter
{
    public class Adaptee
    {
        public void RequestToAdapt()
        {
            Console.WriteLine("Request to adapt");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            ITarget target = new ClassLevelAdapter();
            target.Request();
            
            target = new ObjectLevelAdapter();
            target.Request();
        }
    }
}