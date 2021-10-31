using System;
using System.Collections.Generic;

/*private static int[] memF = new int[100];
private static void Main(string[] args)
{
    Console.WriteLine(Fib(10));
}

private static int Fib(int n)
{
    if (n <= 1) return n;

    if (memF[n] != 0) return memF[n];

    memF[n] = Fib(n - 2) + Fib(n - 1);
    return memF[n];
}*/

namespace fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> fiblist = new List<int>();
            Console.WriteLine(result(Convert.ToInt32(Console.ReadLine()), fiblist));
        }


        static int result(int n, List<int> fiblist)
        {
            if (n == 1 || n == 0) return n;

            if (fiblist.Count >= n && fiblist[n] != 0) return fiblist[n];
            for (int i = 0; i < n; i++)
            {
                fiblist.Add(0);
            }

            fiblist.Add(result(n - 2, fiblist) + result(n - 1, fiblist));
            return fiblist[n];
        }
    }


}
