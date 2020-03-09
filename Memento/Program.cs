namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var originator = new Originator
            {
                State = "On"
            };

            var caretaker = new Caretaker
            {
                Memento = originator.CreateMemento()
            };

            originator.State = "Off";

            originator.SetMemento(caretaker.Memento);
        }
    }
}