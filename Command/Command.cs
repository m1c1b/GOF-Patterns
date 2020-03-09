namespace Command
{
    public abstract class Command
    {
        protected Receiver Receiver { get; set; }

        public Command(Receiver receiver)
        {
            Receiver = receiver;
        }

        public abstract void Execute();
    }
}