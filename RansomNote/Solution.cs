using System;
using System.Collections.Generic;

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
}
