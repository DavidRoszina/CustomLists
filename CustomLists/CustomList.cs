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
        public int c;
        
        
        
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
        //public int this[T obj]
        //{
        //    get
        //    {
        //        for (int i = 0; i < count; i++)
        //        {

        //        }
        //    }
        //}



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
                for (int i = 0; i < count; i++)
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
            //locate item
            T[] tempList = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                tempList[i] = items[i];
            }
            foreach (var i in tempList)
            {
                Console.WriteLine("This list contains values:" + item);
            }
            Console.WriteLine("Which value would you like to remove?\n");
            string itemToGet = Console.ReadLine();
            if (tempList.Contains(itemToGet))
            {
                Console.WriteLine("Value found");
            }
            int indexToRemove = tempList.IndexOf(item);
            if (indexToRemove >= 0)
            {
                tempList[indexToRemove] = default;
            }
            for (int i = indexToRemove; i < items.Length - 1; i++)
            {
                items[i] = items[i + 1];
            }
            count--;
            //declare variable that represents whether something has been removed
            bool itemHasBeenRemoved = false;
            T[] tempItems = new T[capacity];
            if (tempItems.Length < items.Length)
            {
                itemHasBeenRemoved = true;
                for (int i = 0; i < count; i++)
                {
                    tempItems[i] = items[i];
                }
                
            }
            //new array to fill (i=0; i < count; i++)
            
            //if/else (is item in array)(if not, skip)
            //for (int i = 0; i < count; i++)
            //{
            //    items[i] = items[i + 1];
            //}
            //count--;
        }
        public void RemoveAt(int indexToRemove)
        {
            for (int i = indexToRemove; i < items.Length - 1; i++)
            {
                items[i] = items[i + 1];
            }
            count--;
        }
    }
}
