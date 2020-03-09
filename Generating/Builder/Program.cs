using Builder.Builder;

namespace Builder
{
    class Program
    {
        static void Main()
        {
            var builder = new ConcreteBuilder();
            var director = new Director(builder);
            director.Construct();

            var product = builder.GetResult();
            product.Show();
        }
    }
}