using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson10Task2
{
    interface IMyList<T>
    {
        public int Count { get; }
        public void Add(T item);
        public void DeleteByIndex(int index);
    }
}
