using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RansomNote
{
    public class Solution
    {
        public static void checkMagazine(List<string> magazine, List<string> note)
        {
            var dict = new Dictionary<string, int>();

            foreach (var word in magazine)
            {
                var num = magazine.FindAll(arr => arr == word).Count;

                dict.Add(word, num);
            }

            foreach (var word in note)
            {
                try
                {
                    if (dict[word] == 0)
                    {
                        Console.WriteLine("No");
                        return;
                    }
                }
                catch (KeyNotFoundException)
                {
                    Console.WriteLine("No");
                    return;
                }

                
                dict[word]--;
            }

            Console.WriteLine("Yes");

        }
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            using var streamReader =
                new StreamReader(@"C:\Users\Guest-Razor\Downloads\ctci-ransom-note-testcases\input\input21.txt");
            var firstMultipleInput = streamReader.ReadLine()?.TrimEnd().Split(' ');

            var m = Convert.ToInt32(firstMultipleInput[0]);

            var n = Convert.ToInt32(firstMultipleInput[1]);

            var magazine = streamReader.ReadLine().TrimEnd().Split(' ').ToList();

            var note = streamReader.ReadLine().TrimEnd().Split(' ').ToList();

            Solution.checkMagazine(magazine, note);



        }
    }
}
