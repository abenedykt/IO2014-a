using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2
{
    public static class Utility
    {
        public static IEnumerable<IEnumerable<T>> Partition<T>(this List<T> source, int size)
        {
            for (var i = 0; i < Math.Ceiling(source.Count / (Double)size); i++)
                yield return source.Skip(size * i).Take(size);
        }

        public static double ToDouble(this string str)
        {
            return double.Parse(str);
        }
    }
}
