using Facade.Systems;

namespace Facade
{
    public class Facade
    {
        private System1 _system1 = new System1();
        private System2 _system2 = new System2();
        private System3 _system3 = new System3();

        public Facade()
        {
        }

        public void MethodA()
        {
            _system1.MethodOne();
            _system3.MethodThree();
        }
        
        public void MethodB()
        {
            _system2.MethodTwo();
            _system1.MethodOne();
        }
    }
}