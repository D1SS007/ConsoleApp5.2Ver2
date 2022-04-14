using System;
using System.Collections.Generic;

namespace ConsoleApp5._2Ver2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Queue<int> customers = new Queue<int>();

            customers.Enqueue(10);
            customers.Enqueue(20);
            customers.Enqueue(30);
            customers.Enqueue(50);
            customers.Enqueue(60);
            customers.Enqueue(70);
            customers.Enqueue(80);
            customers.Enqueue(90);
            customers.Enqueue(100);
            customers.Enqueue(200);
            customers.Enqueue(300);

            while (customers.Count > 0)
            {
                sum += customers.Dequeue();
                Console.WriteLine(sum);
                Console.ReadKey();
            }
            if (customers.Count == 0)
            {
                Console.WriteLine("Покупателей больше нет.");
                Console.ReadKey();
            }
        }
    }
}
