using System;

namespace lesson1
{
    public class TestCase
    {
        public int X { get; set; }
        public bool Expected { get; set; }
        public Exception ExpectedException { get; set; }
    }
    public class TestCaseNew
    {
        public string X { get; set; }
        public bool Expected { get; set; }
        public Exception ExpectedException { get; set; }
    }
    class Program
    {
        static void TestNumber(TestCase testCase)
        {
            try
            {
                var actual = getAns(testCase.X);

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

        static void Main(string[] args)
        {
            //Вот такая петрушка, на рабочей машине приходится указывать, что работаем в юникоде
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Проверка числа на простое. \nВведите проверяемое число!");
            if (getAns(int.Parse(Console.ReadLine())))
            {
                Console.WriteLine("Введенное число простое!");
            }
            else
            {
                Console.WriteLine("Введенное число не простое!");
            }


            var testCase1 = new TestCase()
            {
                X = 4,
                Expected = false,
                ExpectedException = null
            };
            var testCase2 = new TestCase()
            {
                X = 7,
                Expected = true,
                ExpectedException = null
            };
            var testCase3 = new TestCase()
            {
                X = -7,
                Expected = true,
                ExpectedException = null
            };
            var testCase4 = new TestCase()
            {
                X = 1,
                Expected = true,
                ExpectedException = null
            };
            var testCase5 = new TestCase()
            {
                X = 2147483647,
                Expected = true,
                ExpectedException = null
            };
            TestNumber(testCase1); 
            TestNumber(testCase2);
            TestNumber(testCase3);
            TestNumber(testCase4);
            TestNumber(testCase5);
        }

        static bool getAns(int numberic)
        {
            int d = 0;
            int i = 2;
            bool check = false;
            while (i < numberic)
            {
                if (numberic % i == 0)
                {
                    d++;
                }
                i++;
            }
            if (d == 0)
            {
                check = true;
            }
            return check;
        }
    }
}