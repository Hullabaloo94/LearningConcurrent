using System;
using System.Collections.Concurrent;
using System.Threading;

namespace LearningConcurrent
{
    class Program
    {
        static ConcurrentDictionary<int, int> item = new ConcurrentDictionary<int, int>();

        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(AddItem));
            Thread thread2 = new Thread(new ThreadStart(AddItem));

            thread1.Start();
            thread2.Start();
        }

        static void AddItem() 
        {
            item.TryAdd(1, 2);
            Console.WriteLine(item.Count);
        }
    }
}
