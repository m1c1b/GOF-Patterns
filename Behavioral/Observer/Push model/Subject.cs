using System.Collections;

namespace Observer.Push_model
{
    public abstract class Subject
    {
        private ArrayList _observers = new ArrayList();
        public abstract string State { get; set; }

        public void Attach(Observer o) => _observers.Add(o);

        public void Detach(Observer o) => _observers.Remove(o);

        public void Notify()
        {
            foreach (Observer o in _observers)
                o.Update(State);
        }
    }
}