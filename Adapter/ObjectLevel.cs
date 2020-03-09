namespace Adapter
{
    public class ObjectLevelAdapter : Adaptee, ITarget
    {
        private readonly Adaptee _adaptee = new Adaptee();
        public void Request()
        {
             _adaptee.RequestToAdapt();
        }
    }
}