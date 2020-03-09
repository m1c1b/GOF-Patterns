namespace Chain_of_Responsibility
{
    public abstract class Handler
    {
        public Handler Successor { get; set; }
        public abstract void HandleRequest(int request);
    }
}