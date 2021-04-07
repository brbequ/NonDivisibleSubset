using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'nonDivisibleSubset' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. INTEGER_ARRAY s
     */

    public static int nonDivisibleSubset(int k, List<int> s)
    {
        // Create an array of size k with counts of the remainders
        int[] counts = new int[k];
        foreach (int value in s)
        {
            counts[value % k] += 1;            
        }

        // Initialize the count to 0 or 1
        int count = Math.Min(counts[0], 1);

        // Remainders that are evenly divisible have to make a choice
        // for the count with the highest value
        for (int i = 1; i < k - i; i++)
        {
            count += Math.Max(counts[i], counts[k - i]);
        }

        // If k is even, then add one more
        if (k % 2 == 0)
            count++;

        return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int k = 1;

        //List<int> s = new List<int> { 278, 576, 496, 727, 410, 124, 338, 149, 209, 702, 282, 718, 771, 575, 436 };
        List<int> s = new List<int> { 1,2,3,4,5 };

        int result = Result.nonDivisibleSubset(k, s);

        Console.WriteLine(result);
    }
}
