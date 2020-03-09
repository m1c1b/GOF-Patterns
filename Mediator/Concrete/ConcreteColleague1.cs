using System;
using Mediator.Abstract;

namespace Mediator.Concrete
{
    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Abstract.Mediator mediator) : base(mediator)
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