namespace Flyweight
{
    public class UnsharedConcreteFlyweight : Flyweight
    {
        private int _allState;
        public override void Operation(int extrinsicState)
        {
            _allState = extrinsicState;
        }
    }
}