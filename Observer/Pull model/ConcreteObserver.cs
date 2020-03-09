namespace Observer.Pull_model
{
    public class ConcreteObserver : Observer
    {
        private string _observerState;
        private ConcreteSubject _subject;

        public ConcreteObserver(ConcreteSubject subject)
        {
            _subject = subject;
        }

        public override void Update()
        {
            _observerState = _subject.State;
        }
    }
}