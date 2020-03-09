namespace Proxy
{
    public class Proxy : ISubject
    {
        private RealSubject _realSubject;

        public Proxy(RealSubject realSubject)
        {
            this._realSubject = realSubject;
        }

        public void Request()
        {
            _realSubject?.Request();
        }
    }
}