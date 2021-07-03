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
                if(dict.ContainsKey(word)){
                    dict[word]++;
                    continue;
                }
                dict.Add(word, 1);
            }

            foreach (var word in note)
            {
                if(!dict.ContainsKey(word) || dict[word] == 0) {
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
