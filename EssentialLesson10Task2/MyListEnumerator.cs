using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson10Task2
{
    class MyListEnumerator<T> : IEnumerator
    {
        int index = -1;
        T[] items;

        public MyListEnumerator(T[] items)
        {
            this.items = items;
        }

        object IEnumerator.Current => items[index];

        public bool MoveNext()
        {
            index++;
            return (index >= items.Length) ? false : true;
        }

        public void Reset()
        {
            index = -1;
        }

    }
}
