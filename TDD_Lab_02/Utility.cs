using System.Collections.Generic;

namespace TDD_Lab_02
{
    public static class Utility
    {
        public static IEnumerable<IEnumerable<T>> Partition<T>(this IEnumerable<T> seq, int size)
        {
            using (var @enum = seq.GetEnumerator())
            {
                while (@enum.MoveNext())
                    yield return GetOneCycle(@enum, size);
            }
        }

        private static IEnumerable<T> GetOneCycle<T>(IEnumerator<T> @enum, int size)
        {
            var i = 1;
            do
            {
                yield return @enum.Current;
                i++;
            } while (@enum.MoveNext() && i < size);
        }

        public static double ToDouble(this string s)
        {
            return double.Parse(s);
        }

        public static int ToInt(this string s)
        {
            return int.Parse(s);
        }
    }
}