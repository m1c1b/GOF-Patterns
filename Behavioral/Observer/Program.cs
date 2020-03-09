using Observer.Push_model;

namespace Observer
{
    class Program
    {
        static void Main()
        {
            //For both models
            var subject = new ConcreteSubject();
            subject.Attach(new ConcreteObserver(subject));
            subject.Attach(new ConcreteObserver(subject));
            subject.State = "State";
            subject.Notify();
        }
    }
}