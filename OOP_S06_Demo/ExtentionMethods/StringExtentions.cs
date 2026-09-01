using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_S06_Demo.ExtentionMethods;

internal static class StringExtentions
{
    public static string RemoveVowels(this string str)
    {
        List<char> vowels = new List<char>() { 'a', 'e', 'o', 'u', 'i' };
        StringBuilder stringBuilder = new StringBuilder();
        foreach (char ch in str)
        {
            if (!vowels.Contains(ch))
            {
                stringBuilder.Append(ch);
            }
        }
        return stringBuilder.ToString();
    }
}
