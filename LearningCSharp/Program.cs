using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LearningCSharp
{


    internal class Program
    {
        static int start;
        static int end;
        static int row;

        private Program()
        {
            start = 0;
            end = 2;
            row = 0;
        }
        private static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@"C:\Users\Guest-Razor\source\repos\LearningCSharp\LearningCSharp\newfile.txt", true);

            var lines = File.ReadAllLines(@"C:\Users\Guest-Razor\Downloads\2d-array-testcases\input\input09.txt");


            var arr = lines.Select(line => line.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList()).ToList();

            var result = hourglassSum(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

        public static int hourglassSum(List<List<int>> arr)
        {
            var sum = 0;
            var max = int.MinValue;
            end = 2;
            for (var i = 0; i < 16; i++)
            {
                

                sum = Add(GetEveryNthElements(arr[row], 1, start, end), GetEveryNthElements(arr[row + 1], 2, start, end),
                    GetEveryNthElements(arr[row + 2], 1, start, end));

                if (end == 5) row++;

                Setup();

                if (max < sum) max = sum;
            }

            return max;
        }

        public static void Setup()
        {
            start = ++start % 4;
            end = start + 2;
        }

        public static int GetEveryNthElements(List<int> list, int n, int start, int end)
        {
            var tempList = new List<int>();

            for (var i = start; i <= end; i++)
            {
                var increment = i + 1;

                if (start % 2 != 0) increment = i;
                if (increment % n == 0) tempList.Add(list[i]);
            }

            return Add(tempList);
        }

        public static int Add(params int[] args)
        {
            return args.Sum();
        }

        public static int Add(List<int> list)
        {
            return list.Sum();
        }


    }

}


