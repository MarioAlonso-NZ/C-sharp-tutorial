namespace Oriented_Object_Programming.Company
{
    public class Collection<T>
    {
        private int _length;
        private T[] _items;
        private int _index;

        public Collection(int length)
        {
            _length = length;
            _items = new T[length];
        }
        public void Add(T item)
        {
            if (_items == null)
            {
                _items = new T[1];
            }
            if (_index == _length)
            { 
                Console.WriteLine("Collection is full. Cannot add more items.");
                return;
            }
            /*
            else if (_length == _items.Length)
            {
                Array.Resize(ref _items, _items.Length * 2);
            }
            */
            _items[_index] = item;
            _index++;
        }
        public T[] Get() =>
            _items;
    }
}
