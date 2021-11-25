using System;
using System.Collections.Generic;


namespace fibonachi
{
    public class TestCase
    {
        public int X { get; set; }
        public int Expected { get; set; }
        public Type ExpectedException { get; set; }
    }


    class Program
    {
        static void TestFibRecursive(TestCase testCase)
        {
            List<int> testlist = new List<int>();
            try
            {
                var actual = resultRecursive(testCase.X, testlist);

                if (actual == testCase.Expected)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch (StackOverflowException)
            {
                   Console.WriteLine("VALID TEST");

            }
            catch (Exception ex)
            {
                if (testCase.ExpectedException != null)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            
        }

        static void TestFibLoop(TestCase testCase)
        {
            List<int> testlist = new List<int>();
            try
            {
                var actual = resultLoop(testCase.X);

                if (actual == testCase.Expected)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch (Exception ex)
            {
                if (testCase.ExpectedException != null && ex.GetType() == testCase.ExpectedException)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
        }
        static void Main(string[] args)
        {
            List<int> fiblist = new List<int>();
            Console.WriteLine("Рассчет числа фибоначчи! Введите N!");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                fiblist.Add(0);
            }
            Console.WriteLine(resultRecursive(n, fiblist));
            Console.WriteLine(resultLoop(n));

            var testCase1 = new TestCase() //не понимаю, почему он invalid. туплю.
            {
                X = 8,
                Expected = 21,
                ExpectedException = null
            };
            var testCase2 = new TestCase()
            {
                X = 0,
                Expected = 0,
                ExpectedException = null
            };
            var testCase3 = new TestCase()
            {
                X = 1,
                Expected = 1,
                ExpectedException = null
            };
            var testCase4 = new TestCase()
            {
                X = 8,
                Expected = 45,
                ExpectedException = null
            };
            var testCase5 = new TestCase()
            {
                X = 1000000,
                Expected = 21,
                ExpectedException = typeof(System.StackOverflowException) //оно не ловится, ступил
            };
            Console.WriteLine("\n\n tests==============================================================================================");
            TestFibRecursive(testCase1);
            TestFibRecursive(testCase2);
            TestFibRecursive(testCase3);
            TestFibRecursive(testCase4);
            //TestFibRecursive(testCase5);

            Console.WriteLine("===================================================================================================");

            TestFibLoop(testCase1);
            TestFibLoop(testCase2);
            TestFibLoop(testCase3);
            TestFibLoop(testCase4);
            TestFibLoop(testCase5);
            Console.WriteLine("===================================================================================================");
        }


        static int resultRecursive(int n, List<int> fiblist)
        {
            if (n == 1 || n == 0) return n;

            if (fiblist.Count >= n && fiblist[n] != 0) return fiblist[n];
            fiblist[n] = resultRecursive(n - 2, fiblist) + resultRecursive(n - 1, fiblist);
            return fiblist[n];
        }

        static int resultLoop(int n)
        {
            int a = 0, b = 1, c = 0;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
    }
}
