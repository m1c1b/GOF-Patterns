using System.Collections;

namespace Iterator
{
    //In .net this is Enumerable
    public class ConcreteAggregate : Aggregate
    {
        private ArrayList _items = new ArrayList();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public override int Count => _items.Count;

        public override object this[int index]
        {
            get => _items[index];
            set => _items.Insert(index, value);
        }
    }
}