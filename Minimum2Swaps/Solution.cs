using System;
using System.Collections.Generic;
using System.Linq;

namespace Minimum2Swaps
{
    public class Solution
    {

        public static int MinimumSwaps(int[] arr)
        {
            var listOfPairs = arr.Select((n, i) => new {n, i})
                .Select(number => new Tuple<int, int>(number.n, number.i)).ToList();

            var len = listOfPairs.Count;

            var sortedListOfPairs = listOfPairs.OrderBy(pair => pair.Item1).ToList();

            var visited = new bool[len];

            var totalCycles = 0;

            for (var i = 0; i < len; i++)
            {
                if (visited[i] || sortedListOfPairs[i].Item1 == i) continue;

                var j = i;

                var cycle = 0;

                while (!visited[j])
                {
                    visited[j] = true;

                    j = sortedListOfPairs[j].Item2;

                    cycle++;
                }

                if(cycle > 0) totalCycles += (cycle - 1);
            }

            return totalCycles;
        }
    }
}