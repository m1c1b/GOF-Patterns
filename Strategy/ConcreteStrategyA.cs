using System;

namespace Strategy
{
    public class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("ConcreteStrategyA");
        }
    }
}