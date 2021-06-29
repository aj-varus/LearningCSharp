using System.Collections.Generic;
using System;
using System.Linq; 


namespace ArraysLeftRotation
{
    class Result1
    {

    /*
     * Complete the 'minimumBribes' function below.
     *
     * The function accepts INTEGER_ARRAY q as parameter.
     */

    // public static void minimumBribes(List<int> q)
    // {

    // }
    
        public static void minimumBribes(List<int> q)
        {
            //Arjun : Attempt 1
            //var countBribes = 0;
            //var bribeSum = 0;

            //for (var i = 0; i < input.Count; i++)
            //{
            //    var item = input[i];
            //    var currentIndex = i;
            //    countBribes = 0;

            //    while (currentIndex > 0 && input[currentIndex - 1] > item)
            //    {
            //        if (countBribes > 2) { Console.WriteLine("Too chaotic"); return; }

            //        input[currentIndex] = input[currentIndex - 1];
            //        currentIndex--;

            //        countBribes++;
            //    }

            //    input[currentIndex] = item;
            //    bribeSum += countBribes;
            //}

            //Console.WriteLine($"{bribeSum}");


            //Arjun : Attempt 2
            //var calculatedList = input.Select(
            //    (n, idx) => Math.Abs(n - (idx + 1)) 
            //        switch 
            //        {> 2 => -1, 
            //            _ => Math.Abs(n - (idx + 1))
            //        }

            //    )
            //    .ToList();

            //Console.WriteLine(
            //    calculatedList
            //        .Contains(-1) ? 
            //        "Too chaotic" : calculatedList.Sum().ToString());
            ;
            //Debug
            // foreach (var number in input)
            // {
            //     System.Console.WriteLine($"{number} ");
            // }

            //Arjun : Third attempt with a little help from the discussion forum
            //Take sublist up until the nth index 
            //Find number of numbers greater than the last last number

            //var totalBribes = 0;

            //for (var i = 1; i < input.Count; i++)
            //{
            //    var tmpList = input.GetRange(0, i + 1);
            //    var bribes = tmpList.Count(number => number > tmpList[^1]);

            //    if (bribes > 2)
            //    {
            //        Console.WriteLine("Too chaotic");
            //        return;
            //    }

            //    totalBribes += bribes;
            //}

            //Console.WriteLine(totalBribes);


            //Arjun : Copied solution from Hackerrank
            var ans = 0;
            for (var i = q.Count - 1; i >= 0; i--)
            {
                if (q[i] - (i + 1) > 2)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
                for (var j = Math.Max(0, q[i] - 2); j < i; j++)
                    if (q[j] > q[i]) ans++;
            }

            Console.WriteLine($"{ans}");

            
        }   
    }
}
