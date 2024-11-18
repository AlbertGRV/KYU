using System;

public static class Kata
{
    public static string ExpandedForm(long num)
    {
        string numberStr = num.ToString(); 
        int length = numberStr.Length; 
        string result = ""; 

        for (int i = 0; i < length; i++)
        {
            char digit = numberStr[i]; 
            if (digit != '0') 
            {
                
                long value = (digit - '0') * (long)Math.Pow(10, length - i - 1);
                
                if (result.Length > 0)
                {
                    result += " + ";
                }
                result += value; 
            }
        }

        return result;
    }
}
