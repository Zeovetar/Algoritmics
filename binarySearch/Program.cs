using System;

//!!!Ассимптотическая сложность бинарного поиска Log2(n+1). Сам дошел только до (n+1)/2 дальше подсмотрел в википедии. В целом не понял, почему пришли именно к логарифму и именно к такому (n+1)

namespace binarySearch
{
    public class TestCase
    {
        public int X { get; set; }
        public int Expected { get; set; }
        public Exception ExpectedException { get; set; }
        public int[] arr { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var array = new int[] { 19, 14, 198, -248, -228, -246, -134, 23, -126, -69, 290, 82, 126, 86, 31, 245, -187, 213, 165, 23,
                65, -179, 143, 151, 163, -38, -133, -158, 112, -149, 54, -203, -105, 50, -195, 255, -20, -158, 111, -208, 121, 268, 
                89, 300, 16, 253, -27, 60, 271, 126, 127, -123, 47, 205, 197, -104, 171, -254, -111, 110, 187, -278, 211, -278, 177, 
                191, -115, -226, -20, 76, -37, 272, -200, 72, 202, 98, 32, 144, -167, 211, 290, 108, -128, 286, 24, -125, 51, -9, 154, 
                209, -217, -68, 253, -301, -94, 98, -244, 66, -179, };
            Array.Sort(array);
            Console.WriteLine();
            foreach (int i in array)
                Console.Write($"{i} ");

            Console.WriteLine($"\nHere it is! {BinarySearch(array, -105)}");

            var testCase1 = new TestCase()
            {
                X = -105,
                Expected = 29,
                ExpectedException = null
            };

            var testCase2 = new TestCase()
            {
                X = 302,
                Expected = -1,
                ExpectedException = null
            };


            var testCase3 = new TestCase()
            {
                X = -105,
                Expected = 30,
                ExpectedException = null
            };


            var testCase4 = new TestCase()
            {
                X = -105,
                Expected = 29,
                ExpectedException = null,
                arr = { }
            };

            TestArray(testCase1, array);
            TestArray(testCase2, array);
            TestArray(testCase3, array);
            TestArray(testCase4,testCase4.arr);

        }

        public static int BinarySearch(int[] inputArray, int searchValue)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (searchValue == inputArray[mid])
                {
                    return mid;
                }
                else if (searchValue < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }

        static void TestArray(TestCase testCase, int [] arr)
        {
            try
            {
                var actual = BinarySearch(arr, testCase.X);

                if (actual == testCase.Expected)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("VALID TEST");
            }
            catch (Exception ex)
            {
                if (testCase.ExpectedException != null)
                {
                    Console.WriteLine($"VALID TEST &{ex.Message}");
                }
                else
                {
                    Console.WriteLine($"INVALID TEST &{ex.Message}");
                }
            }
        }
    }
}
