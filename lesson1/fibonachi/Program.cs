using System;
using System.Collections.Generic;


namespace fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> fiblist = new List<int>();
            Console.WriteLine("Рассчет числа фибоначчи! Введите N!");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                fiblist.Add(0);
            }
            Console.WriteLine(result(n, fiblist));
        }


        static int result(int n, List<int> fiblist)
        {
            if (n == 1 || n == 0) return n;

            if (fiblist.Count >= n && fiblist[n] != 0) return fiblist[n];
            fiblist[n] = result(n - 2, fiblist) + result(n - 1, fiblist);
            return fiblist[n];
        }
    }


}
