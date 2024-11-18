using System;

public class Kata
{
    public static int Solve(string s)
    {
        string vowels = "aeiou"; 
        int maxSum = 0; 
        int currentSum = 0; 

        foreach (char c in s)
        {
            if (!vowels.Contains(c)) 
            {
                currentSum += c - 'a' + 1; 
                maxSum = Math.Max(maxSum, currentSum); 
            }
            else
            {
                currentSum = 0; 
            }
        }

        return maxSum;
    }
}

