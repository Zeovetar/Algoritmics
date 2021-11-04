using System;

namespace binarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var array = new int[100];
            for (int i = 0; i < array.Length-1; i++)
            {
                array[i] = rand.Next(-301,301);
                Console.Write($"{array[i]} ");
            }
            Array.Sort(array);
            Console.WriteLine();
            foreach (int i in array)
                Console.Write($"{i} ");

            Console.WriteLine($"\nHere it is! {BinarySearch(array, 292)}");
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
    }
}
