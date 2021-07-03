using System;
using System.IO;
using System.Linq;

namespace RansomNote
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using var streamReader =
                new StreamReader(@"/Users/arjunsen/Downloads/input01.txt");
            var firstMultipleInput = streamReader.ReadLine()?.TrimEnd().Split(' ');

            var m = Convert.ToInt32(firstMultipleInput[0]);

            var n = Convert.ToInt32(firstMultipleInput[1]);

            var magazine = streamReader.ReadLine().TrimEnd().Split(' ').ToList();

            var note = streamReader.ReadLine().TrimEnd().Split(' ').ToList();

            Solution.checkMagazine(magazine, note);



        }
    }
}
