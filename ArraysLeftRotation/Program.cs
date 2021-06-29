using System;
using System.IO;
using System.Linq;

namespace ArraysLeftRotation
{
    internal class Program
    {

        //Calling Result.cs
        // public static void Main(string[] args)
        // {
        //     using var textWriter = new StreamWriter(@"output.txt", false);
        //     //var lines = File.ReadAllLines(@"/Users/arjunsen/Downloads/ctci-array-left-rotation-testcases/input/input10.txt");
        //     using var lines = new StreamReader(@"/Users/arjunsen/Downloads/ctci-array-left-rotation-testcases/input/input10.txt");

        //     string[] firstMultipleInput = lines.ReadLine().TrimEnd().Split(' ');

        //     int n = Convert.ToInt32(firstMultipleInput[0]);

        //     int d = Convert.ToInt32(firstMultipleInput[1]);

        //     List<int> a = lines.ReadLine()
        //         .TrimEnd()
        //         .Split(' ')
        //         .ToList()
        //         .Select(aTemp => Convert.ToInt32(aTemp))
        //         .ToList();

        //     List<int> result = Result.rotLeft(a, d);

        //     textWriter.WriteLine(string.Join(" ", result));
        // }

        public static void Main(string[] args)
        {
            using var streamReader = new StreamReader(@"C:\Users\Guest-Razor\Downloads\new-year-chaos-testcases\input\input00.txt");
            var t = Convert.ToInt32(streamReader.ReadLine()?.Trim());

            for (var tItr = 0; tItr < t; tItr++)
            {
                var n = Convert.ToInt32(streamReader.ReadLine()?.Trim());

                var q = streamReader.ReadLine()?
                    .TrimEnd()
                    .Split(' ')
                    .ToList()
                    .Select(qTemp => Convert.ToInt32(qTemp))
                    .ToList();

                Result1.minimumBribes(q);
            }
        }
    }
}
