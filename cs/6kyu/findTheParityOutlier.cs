// --Description--

// You are given an array (which will have a length of at least 3, but could be very large) containing integers. The array is either entirely comprised of odd integers or entirely comprised of even integers except for a single integer N. Write a method that takes the array as an argument and returns this "outlier" N.

// --Solution--

using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
    public static int Find(int[] integers)
    {
        int evenCount = 0;
        int oddCount = 0;
        int mostRecentEven = 0;
        int mostRecentOdd = 0;
        for (int i = 0; i < integers.Length; i++)
        {
            if (integers[i] % 2 == 0)
            {
                evenCount++;
                mostRecentEven = integers[i];
            }
            else
            {
                oddCount++;
                mostRecentOdd = integers[i];
            }
        }
        if (evenCount == 1)
        {
            return mostRecentEven;
        }
        else
        {
            return mostRecentOdd;
        }

    }
}