namespace Strategy
{
    public class Context
    {
        private Strategy Strategy { get; set; }

        public Context(Strategy strategy)
        {
            Strategy = strategy;
        }

        public void ContextInterface()
        {
            Strategy.AlgorithmInterface();
        }
    }
}