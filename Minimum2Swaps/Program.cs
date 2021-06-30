using System;
using System.IO;

namespace Minimum2Swaps
{
    internal class Program
    {
        private static void Main()
        {
            using var streamReader = new StreamReader(@"C:\Users\Guest-Razor\Downloads\minimum-swaps-2-testcases\input\input02.txt", true);

            var n = Convert.ToInt32(streamReader.ReadLine());

            var arr = Array.ConvertAll(streamReader.ReadLine()?.Split(' ') ?? Array.Empty<string>() , Convert.ToInt32);
            var res = Solution.MinimumSwaps(arr);

            Console.WriteLine(res);
        }
    }
}
