using EssentialLesson10Task2;
using EssentialLesson10Task2ExtensionMethod;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EssentialLesson10Task2
{

    //    Задание 2
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте класс MyList<T>. Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса List<T>. 
    //    Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления элемента, индексатор для получения значения элемента по указанному индексу
    //    и свойство только для чтения для получения общего количества элементов.

    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();

            list.Add(15);
            list.Add(23);
            list.Add(14);
            list.Add(116);
            list.Add(1234);

            Console.WriteLine(list.Count);

            int[] items = list.GetArray<int>();

            foreach (int item in items)
            {
                Console.WriteLine(item);
            }
        }

    }
}


namespace EssentialLesson10Task2ExtensionMethod
{
    //        Задание 4
    //Используя Visual Studio, создайте проект по шаблону Console Application.Создайте расширяющий метод: public static T[] GetArray<T>(this MyList<T> list)
    //Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2 для данного урока.Выведите на экран значения элементов массива, который вернул расширяющий метод GetArray().
    static class ExtClass
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            if (list == null)
            {
                return null;
            }
            else
            {
                T[] items = new T[list.Count];

                for (int i = 0; i < list.Count; i++)
                {
                    items[i] = list[i];
                }
                return items;
            }
        }
    }
}