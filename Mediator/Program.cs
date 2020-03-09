using Mediator.Concrete;

namespace Mediator
{
    class Program
    {
        static void Main()
        {
            var mediator = new ConcreteMediator();
            var colleague1 = new ConcreteColleague1(mediator);
            var colleague2 = new ConcreteColleague2(mediator);

            mediator.Colleague1 = colleague1;
            mediator.Colleague2 = colleague2;
            colleague1.Send("Message A");
            colleague2.Send("Message B");
        }
    }
}