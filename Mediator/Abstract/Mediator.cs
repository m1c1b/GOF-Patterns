namespace Mediator.Abstract
{
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }
}