using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLists
{
    public class CustomList<T>
    {
        // member variables (HAS A)
        private T[] items;
        private int capacity;
        private int count;

        public int Count
        {
            get
            {
                return count;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }
        public T this[int index]
        {
            get
            {
                if (index < count && index >= 0)
                {
                    return items[index];
                }
                else;
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                items[index] = value;

            }
        }

        // constructor (SPAWNER)
        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
        }

        // member methods (CAN DO)
        public void Add(T item)
        {
            

            if (count < capacity)
            {
                items[count] = item;
                count++;
            }
            else
            {
                capacity = (capacity * 2);
                T[] biggerItems = new T[capacity];
                count++;
            }
        }
    }
}
