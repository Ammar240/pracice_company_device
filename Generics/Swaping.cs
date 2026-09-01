using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics;

internal static class Swaping
{
    public static void Swap<T>(ref T x,ref T y)
    {
        T temp = x;
        x = y;
        y = temp;
    }
}
