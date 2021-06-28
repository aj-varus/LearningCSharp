using System.Collections.Generic;

namespace ArraysLeftRotation
{

    class Result
    {

        /*
         * Complete the 'rotLeft' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER d
         */

        public static List<int> rotLeft(List<int> a, int d)
        {
            for (var i = 1; i <= d; i++)
            {
                var firstElement = a[0];
                a.RemoveAt(0);
                a.Add(firstElement);
            }


            return a;

        }

    }
}
