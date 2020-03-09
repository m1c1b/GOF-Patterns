using System;
namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance1 = Singleton.Instance();
            var instance2 = Singleton.Instance();
            Console.WriteLine(ReferenceEquals(instance1, instance2));

            instance1.SingletonOperation();
            var singletonData = instance1.GetSingletonData();
            Console.WriteLine(singletonData);
        }
    }
}