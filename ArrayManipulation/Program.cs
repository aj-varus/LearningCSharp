using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ArrayManipulation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using var streamReader = new StreamReader(@"C:\Users\Guest-Razor\Downloads\crush-testcases\input\input14.txt");

            var firstMultipleInput = streamReader.ReadLine().TrimEnd().Split(' ');

            var n = Convert.ToInt32(firstMultipleInput[0]);

            var m = Convert.ToInt32(firstMultipleInput[1]);

            var queries = new List<List<int>>();

            for (var i = 0; i < m; i++)
            {
                queries.Add(streamReader.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            }

            var result = Solution.ArrayManipulation(n, queries);

            Console.WriteLine(result);

        }
    }
}
