using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    /// <summary>
    /// A dynamically sized generic array
    /// </summary>
    class ArrayList<T> : IEnumerable<T>
    {
        private const int InitSize = 4;
        private int actualSize;
        private int itemCount;
        private T[] items;

        /// <summary>
        /// Returns the number of elements in the ArrayList
        /// </summary>
        public int Count { get { return itemCount; } }

        /// <summary>
        /// Returns the current capacity of the ArrayList
        /// </summary>
        public int Size { get { return actualSize; } }

        /// <summary>
        /// Instantiates a new ArrayList of type T
        /// </summary>
        public ArrayList()
        {
            items = new T[InitSize];
            actualSize = InitSize;
            itemCount = 0;
        }

        /// <summary>
        /// Instantiates a new ArrayList and sets it to the value of items
        /// </summary>
        /// <param name="items">A T[] of items</param>
        public ArrayList(params T[] items)
        {
            // Copying the array like this prevents modification of the internal array
            // when the array passed to the method is modified afterwards
            this.items = new T[items.Length];
            Array.Copy(items, this.items, items.Length);

            actualSize = this.items.Length;
            itemCount = this.items.Length;
        }

        /// <summary>
        /// Adds the item of type T to the array list
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            if (itemCount == actualSize)
            {
                AllocateLargerArray();
            }
            items[itemCount] = item;
            itemCount++;
        }

        public T this[int idx]
        {
            get
            {
                return items[idx];
            }

            set
            {
                items[idx] = value;
            }
        }

        private void AllocateLargerArray()
        {
            var newArray = new T[actualSize *= 2];
            Array.Copy(items, newArray, items.Length);
            items = newArray;
        }

        // TODO: Correctly implement these in order to use foreach
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
