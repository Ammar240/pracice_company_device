using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP06.ExtentionMethods
{
    internal static class PersonExtentions
    {
        public static string GetDisplayName(this Person person)
        {
            return $"{person.Name} ({person.Age})";
        }

        public static bool IsAdult(this Person person)
        {
            return person.Age >= 18;
        }

        public static object CanClone(this ICloneable cloneable)
        {
            return cloneable.Clone();
        }
    }
}
