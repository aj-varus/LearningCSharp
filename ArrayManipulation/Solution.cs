using System;
using System.Collections.Generic;

namespace ArrayManipulation
{
    public class Solution
    {
        //public static long ArrayManipulation(int n, List<List<int>> queries)
        //{
        //    var a = new long[n];
        //    var max = long.MinValue;

        //    foreach (var query in queries)
        //    {
        //        for (var i = query[0] - 1; i <= query[1] - 1; i++)
        //        {
        //            a[i] += query[2];

        //            if (a[i] > max) max = a[i];
        //        }
        //    }

        //    return max;
        //}

        public static unsafe long ArrayManipulation(int n, List<List<int>> queries)
        {
            long max = 0, x = 0;

            long K = queries.Count;

            fixed (long* a = new long[n + 1])
            {
                for (var idx = 0; idx < K; idx++)
                {
                    long p = queries[idx][0];
                    long q = queries[idx][1];
                    long sum = queries[idx][2];

                    a[p] += sum;

                    if ((q + 1) <= n) a[q + 1] -= sum;
                }

                long i;
                for (i = 1; i <= n; i++)
                {
                    x += a[i];
                    if (max < x) max = x;
                }
                return max;
            }
        }
    }

    
}