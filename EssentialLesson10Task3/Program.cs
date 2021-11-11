using System;

namespace EssentialLesson10Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> test = new MyDictionary<string, string>();

            test.Add("Odin", "One");
            test.Add("Dva", "Two");
            test.Add("Tri", "Three");
            test.Add("Chetire", "Four");
            //test.DeleteByKey("Odin");

            Console.WriteLine(test[0]);
            Console.WriteLine(test[1]);
            Console.WriteLine(test[2]);

            Console.WriteLine(test.GetPairByKey("Odin"));

            Console.WriteLine(test.GetPairByValue("One"));

            Console.WriteLine(test.Count);

        }
    }
}
