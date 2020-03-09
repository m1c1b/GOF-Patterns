using System;
using Mediator.Abstract;

namespace Mediator.Concrete
{
    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Abstract.Mediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            Mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine(message);
        }
    }
}