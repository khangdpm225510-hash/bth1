using System.Collections.Generic;

namespace Real_Iterator
{
    public class Collection : IAbstractCollection
    {
        private List<Item> items = new List<Item>();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public int Count
        {
            get { return items.Count; }
        }

        public Item this[int index]
        {
            get { return items[index]; }
            set { items.Add(value); }
        }
    }
}
