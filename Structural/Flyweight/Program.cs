namespace Flyweight
{
    class Program
    {
        static void Main()
        {
            var extrinsicState = 0;

            Flyweight flyweight = null;
            var factory = new FlyweightFactory();

            flyweight = factory.GetFlyweight("1");
            flyweight.Operation(extrinsicState);

            flyweight = factory.GetFlyweight("10");
            flyweight.Operation(extrinsicState);
            
            flyweight = new UnsharedConcreteFlyweight();
            flyweight.Operation(extrinsicState);
        }
    }
}