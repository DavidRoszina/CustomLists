using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLists
{
    public class CustomList<T> : IEnumerable
    {
        // member variables (HAS A)
        private T[] items;
        private int capacity;
        private int count;
        private int i;
        private int index;
        
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }
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
                else
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
                for (i = 0; i < count; i++)
                {
                    biggerItems[i] = items[i];
                }
                items = biggerItems;
                items[count] = item;
                count++;  
            }  
        }
        public void Remove(T item)
        {
            {
                if (count == items.Length)
                {
                    item = default;
                    count--;
                }
                else (i < count)
                {


                    for (int i = index; i < items.Length - 1; i++)
                    {
                        items[i] = items[i + 1];
                    } 
                }
                
            }
        }
    }
}
