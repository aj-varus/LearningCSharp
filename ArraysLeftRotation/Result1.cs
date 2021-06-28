using System.Collections.Generic;
using System;

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
    
    public static void minimumBribes(List<int> input)
{
    var clonedList = new List<int>(input);
    var countBribes = 0;
    
    for (int i = 0; i < input.Count; i++)
    {
        var item = input[i];
        var currentIndex = i;
        
        

        while (currentIndex > 0 && clonedList[currentIndex - 1] > item)
        {
            if(countBribes > 2){ Console.WriteLine("Too chaotic"); break;}  
            currentIndex--;
            
            countBribes++;
        }
        
        if(countBribes > 2) break;

    }
    
    Console.WriteLine($"{countBribes}");

   
}

}
}
