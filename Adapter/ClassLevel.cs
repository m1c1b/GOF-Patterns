namespace Adapter
{
    interface ITarget
    {
        void Request();
    }
    public class ClassLevelAdapter : Adaptee, ITarget
    {
        public void Request()
        {
            RequestToAdapt();
        }
    }
}