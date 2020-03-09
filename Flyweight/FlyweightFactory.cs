using System.Collections;

namespace Flyweight
{
    public class FlyweightFactory
    {
        Hashtable _pool = new Hashtable
        {
            {"1", new ConcreteFlyweight()},
            {"2", new ConcreteFlyweight()},
            {"3", new ConcreteFlyweight()}
        };

        public Flyweight GetFlyweight(string key)
        {
            if (!_pool.ContainsKey(key))
                _pool.Add(key, new ConcreteFlyweight());

            return _pool[key] as Flyweight;
        }
    }
}