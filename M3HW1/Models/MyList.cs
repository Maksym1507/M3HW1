using System.Collections;
using M3HW1.Enumerators;
using M3HW1.Interfaces;

namespace M3HW1.Models
{
    public class MyList<T> : IMyList<T>, IEnumerable<T>
    {
        private T[] _elements;

        public int Count { get; set; }

        public int Capacity { get; set; } = 0;

        public void Add(T item)
        {
            CheckCapacity();

            _elements[Count++] = item;
        }

        public void AddRange(T[] collection)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                CheckCapacity();

                _elements[Count++] = collection[i];
            }
        }

        public bool Remove(T item)
        {
            var isExist = false;

            var indexOfElements = Array.IndexOf(_elements, item);

            if (indexOfElements != -1)
            {
                Count--;

                var elementsCounter = 0;
                var newElements = new T[Capacity];

                for (int i = 0; i < Count; i++)
                {
                    if (indexOfElements == i)
                    {
                        elementsCounter++;
                    }

                    newElements[i] = _elements[elementsCounter++];
                }

                _elements = newElements;

                isExist = true;
            }

            return isExist;
        }

        public void RemoveAt(int index)
        {
            if (index >= Count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            Count--;

            var elementsIndex = 0;

            for (int j = 0; j < _elements.Length; j++)
            {
                if (j == index)
                {
                    j++;
                }

                _elements[elementsIndex++] = _elements[j];
            }
        }

        public void Sort(IComparer<T> comparer)
        {
            Array.Sort(_elements, 0, Count, comparer);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new ElementEnumerator<T>(_elements, Count);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private void CheckCapacity()
        {
            if (Capacity == 0)
            {
                Capacity = 4;

                _elements = new T[Capacity];
            }

            if (Capacity == Count)
            {
                Capacity *= 2;

                var newElements = new T[Capacity];

                for (int i = 0; i < _elements.Length; i++)
                {
                    newElements[i] = _elements[i];
                }

                _elements = newElements;
            }
        }
    }
}
