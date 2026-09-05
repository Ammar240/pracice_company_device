using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_L01.Lecture01;

internal static class Extesions
{
    public static IEnumerable<T> Filter<T>(this IEnumerable<T> items, Predicate<T> predicate)
    {
        Console.WriteLine($"Processing....");
        foreach (var item in items)
        {
            if (predicate(item))
            {
               yield return item;
            }
        }
    }
}
