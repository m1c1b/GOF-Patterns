
namespace Bridge.Abstractions
{
    public abstract class Abstraction
    {
        private Implementor Implementor { get; set; }

        protected Abstraction(Implementor implementor)
        {
            Implementor = implementor;
        }

        public virtual void Operation()
        {
            Implementor.OperationImplementation();
        }
    }
}