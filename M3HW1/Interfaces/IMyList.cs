namespace M3HW1.Interfaces
{
    public interface IMyList<T> : IEnumerable<T>
    {
        public int Count { get; set; }

        public int Capacity { get; set; }

        void Add(T item);

        void AddRange(T[] collection);

        bool Remove(T item);

        void RemoveAt(int index);

        void Sort(IComparer<T> comparer);
    }
}
