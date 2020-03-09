namespace Flyweight
{
    public class ConcreteFlyweight : Flyweight
    {
        private int _intrinsicState;

        public override void Operation(int extrinsicState)
        {
            _intrinsicState = extrinsicState;
        }
    }
}