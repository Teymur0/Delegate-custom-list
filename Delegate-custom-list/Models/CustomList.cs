namespace Delegate_custom_list.Models
{
    internal class CustomList<T>
    {
        private List<T> _list;

        public CustomList()
        {
            _list = new List<T>();
        }

        public void GetAll()
        {
            foreach (var item in _list)
            {
                Console.WriteLine(item);

            }
        }
        public void Add(T item)
        {
            _list.Add(item);

        }
        public void Remove(T item)
        {
            for (int i = 0; i < _list.Count; i++)
            {
                if (_list[i].Equals(item))
                {
                    _list.RemoveAt(i);
                }
            }

        }
        public void RemoveAll(Predicate<T> match)
        {
            for (int i = _list.Count - 1; i >= 0; i--)
            {
                if (match(_list[i]))
                {
                    _list.RemoveAt(i);
                }
            }
        }
        public T Find(Predicate<T> match)
        {
            foreach (var item in _list)
            {
                if (match(item))
                {
                    return item;
                }
            }
            return default;
        }
        public List<T> FindAll(Predicate<T> match)
        {
            List<T> foundElements = new List<T>();
            foreach (var item in _list)
            {
                if (match(item))
                {
                    foundElements.Add(item);
                }
            }
            return foundElements;
        }
        public bool Contains(T item)
        {
            foreach (var el in _list)
            {
                if (el.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
}


