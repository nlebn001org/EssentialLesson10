using System;

namespace EssentialLesson10Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            object a = MyClass<object>.FactoryMethod();
            Console.WriteLine(a.GetType());
        }
    }
}
