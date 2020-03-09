namespace Iterator
{
    //In .net this is Enumerator
    public class ConcreteIterator : Iterator
    {
        private Aggregate _aggregate;

        private int Current { get; set; }

        public ConcreteIterator(Aggregate aggregate)
        {
            _aggregate = aggregate;
        }

        public override object CurrentItem() => _aggregate[Current];

        public override object First() => _aggregate[0];

        public override bool IsDone()
        {
            if (Current < _aggregate.Count)
                return false;

            Current = 0;
            return true;
        }

        public override object Next()
        {
            return Current++ < _aggregate.Count - 1 ? _aggregate[Current] : null;
        }
    }
}