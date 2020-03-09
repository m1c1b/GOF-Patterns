namespace Template_method
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            Operation1();
            Operation2();
        }
        protected abstract void Operation1();
        protected abstract void Operation2();
    }
}