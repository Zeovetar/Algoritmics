using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
            /*
            |               Method |         Mean |      Error |     StdDev |
            |--------------------- |-------------:|-----------:|-----------:|
            | stringArrayBenchmark | 25,354.12 ns | 497.907 ns | 465.742 ns |
            |   hashArrayBenchmark |     12.68 ns |   0.262 ns |   0.257 ns |
             */
        }


    }

    public class BechmarkClass
    {
        static string [] genStr = genStrings();
        HashSet<string> genHash = genHashStrings(genStr);
        string guid = Guid.NewGuid().ToString();


        public static string[] genStrings()
        {
            string[] stringSet = new string[10000];
            var guid = Guid.NewGuid().ToString();
            for (int i = 0; i < 10000; i++)
            {
                guid = Guid.NewGuid().ToString();
                stringSet[0] = guid;
            }
            return stringSet;
        }

        public static HashSet<T> genHashStrings<T>(T[] str)
        {
            var hashSet = new HashSet<T>();
            return new HashSet<T>(str);
        }


        public static int searchInStrArray(string[] str, string guid)
        {
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (guid == str[i])
                    return 1;
            }
            return 0;
        }


        public static int searchInHashArray(HashSet<string> hSet, string guid)
        {
            if (hSet.Contains(guid))
                return 1;
            else
                return 0;
        }

        [Benchmark]
        public void stringArrayBenchmark()
        {
            searchInStrArray(genStr, guid);

        }

        [Benchmark]
        public void hashArrayBenchmark()
        {
            searchInHashArray(genHash,guid);
        }
    }
}
