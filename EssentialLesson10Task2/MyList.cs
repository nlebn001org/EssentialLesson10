using System;
using System.Collections;
using System.Collections.Generic;

namespace EssentialLesson10Task2
{
    class MyList<T> : IMyList<T>, IEnumerable
    {
        #region Probably not right solution...
        //List<T> list = new List<T>();

        //public int Count { get { return list.Count; } }

        //public void Add(T t)
        //{
        //    list.Add(t);
        //}

        //public T GetValueByIndex(int index)
        //{
        //    return list[index];
        //}
        #endregion

        T[] items = new T[0];

        public T this[int index]
        {
            get 
            {
                if (index > items.Length - 1)
                {
                    throw new IndexOutOfRangeException($"Impossible to get value by index {index}");
                }
                return items[index];
            }
        }

        public int Count { get { return items.Length; } }

        public void Add(T item)
        {
            Array.Resize(ref items, items.Length + 1);
            items[items.Length - 1] = item;
        }

        public void DeleteByIndex(int index)
        {
            if (index > items.Length - 1 || index < 0)
            {
                throw new IndexOutOfRangeException($"Impossible to get value by index {index}");
            }

            for (int i = 0; i < items.Length; i++)
            {
                if (index == items.Length - 1)
                {
                    break;
                }
                items[index] = items[index + 1];
                
                index++;
            }
            Array.Resize(ref items, items.Length - 1);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new MyListEnumerator<T>(items);
        }
    }
}
