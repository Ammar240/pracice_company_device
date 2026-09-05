using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_L01.Lecture02;

public static class Extesions2
{
    public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Predicate<T> predicate)
    {
        foreach (var item in source)
        {
            if (predicate(item))
            {
                yield return item;
            }
        }
    }
}
