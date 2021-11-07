using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
/*            var rand = new Random(100);
            for (int i = 0; i < 10; i++)
            {
                PointClass arrGenClass = new PointClass() { X = rand.Next(), Y = rand.Next() };
                PointClass[] arrayPointClass = new PointClass[10];
                arrayPointClass[i] = arrGenClass;
            }
            for (int i = 0; i < 10; i++)
            {
                PointStruct arrGenStruct = new PointStruct() { X = rand.Next(), Y = rand.Next() };
                PointStruct[] arrayPointStruct = new PointStruct[10];
                arrayPointStruct[i] = arrGenStruct;
            }*/
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }

    public class PointClass
    {
        public int X;
        public int Y;
    }

    public struct PointStruct
    {
        public int X;
        public int Y;
    }

    public class BechmarkClass
    {
        public static PointClass[] ClassArray()
        {
            var rand = new Random(100);
            PointClass[] arrayPointClass = new PointClass[10];
            for (int i = 0; i < 10; i++)
            {
                PointClass arrGenClass = new PointClass() { X = rand.Next(), Y = rand.Next() };
                arrayPointClass[i] = arrGenClass;
            }
            return arrayPointClass;
        }

        private PointClass[] clArray = ClassArray();

        public static PointStruct[] StructArray()
        {
            var rand = new Random(100);
            PointStruct[] arrayPointStruct = new PointStruct[10];
            for (int i = 0; i < 10; i++)
            {
                PointStruct arrGenClass = new PointStruct() { X = rand.Next(), Y = rand.Next() };
                arrayPointStruct[i] = arrGenClass;
            }
            return arrayPointStruct;
        }

        private PointStruct[] stArray = StructArray();

        public static float PointDistanceClass(PointClass pointOne, PointClass pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }
        public static float PointDistance(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }

        public static float PointDistanceShort(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return (x * x) + (y * y);
        }

        public static double PointDistanceDouble(PointStruct pointOne, PointStruct pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return Math.Sqrt((x * x) + (y * y));
        }
        

        [Benchmark]
        public void floatPointDistanceClass()
        {
            //PointClass pointOne = new PointClass() { X = 4, Y = 5 };
            //PointClass pointTwo = new PointClass() { X = 12, Y = 24 };
            for (int i = 0; i < 10; i = i + 2)
            {
                PointDistanceClass(clArray[i], clArray[i+1]);
            }
        }

        [Benchmark]
        public void floatPointDistance()
        {
            PointStruct pointOne = new PointStruct() { X = 4, Y = 5 };
            PointStruct pointTwo = new PointStruct() { X = 12, Y = 24 };
            PointDistance(pointOne, pointTwo);
        }

        [Benchmark]
        public void PointDistanceShort()
        {
            PointStruct pointOne = new PointStruct() { X = 4, Y = 5 };
            PointStruct pointTwo = new PointStruct() { X = 12, Y = 24 };
            PointDistanceShort(pointOne, pointTwo);
        }

        [Benchmark]
        public void PointDistanceDouble()
        {
            PointStruct pointOne = new PointStruct() { X = 4, Y = 5 };
            PointStruct pointTwo = new PointStruct() { X = 12, Y = 24 };
            PointDistanceDouble(pointOne, pointTwo);
        }

    }
}

