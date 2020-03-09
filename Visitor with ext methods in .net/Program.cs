using System;

namespace Visitor_with_ext_methods_in_.net
{
    public static class Visitors
    {     
        public static void VisitConcreteElementA(this ElementA element)
        {
            element.OperationA();
        }

        public static void VisitConcreteElementB(this ElementB element)
        {
            element.OperationB();
        }
    }

    public class ElementA
    {
        public void OperationA()
        {
            Console.WriteLine("OperationA");
        }
    }

    public class ElementB
    {
        public void OperationB()
        {
            Console.WriteLine("OperationB");
        }
    }

    class Program
    {
        static void Main()
        {
            var elementA = new ElementA();
            var elementB = new ElementB();

            elementA.VisitConcreteElementA();
            elementB.VisitConcreteElementB();
        }
    }
}