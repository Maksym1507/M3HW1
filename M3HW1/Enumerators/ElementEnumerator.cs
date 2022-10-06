using System.Collections;

namespace M3HW1.Enumerators
{
    public class ElementEnumerator<T> : IEnumerator<T>
    {
        private readonly T[] _elements;

        private readonly int _count;

        private int _position = -1;

        public ElementEnumerator(T[] elements, int count)
        {
            _elements = elements;
            _count = count;
        }

        public T Current
        {
            get
            {
                if (_position == -1 || _position >= _elements.Length)
                {
                    throw new InvalidOperationException();
                }

                return _elements[_position];
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (_position < _count - 1)
            {
                _position++;

                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            _position = -1;
        }
    }
}
