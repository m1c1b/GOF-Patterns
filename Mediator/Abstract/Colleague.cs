namespace Mediator.Abstract
{
    public abstract class Colleague
    {
        protected Mediator Mediator { get; set; }

        protected Colleague(Mediator mediator)
        {
            Mediator = mediator;
        }
    }
}