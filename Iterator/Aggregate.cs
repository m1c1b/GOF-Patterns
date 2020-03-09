namespace Iterator
{
    public abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
        public abstract int Count { get; }

        public abstract object this[int index] { get; set; }
    }
}