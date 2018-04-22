using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack.Extensions
{
    internal static class EnumerableExtensions
    {
        private static Random _rand = new Random();

        public static bool IsEmpty<T>(this IEnumerable<T> source) => !source.Any();

        public static T RandomAt<T>(this IEnumerable<T> source)
        {
            if (source.IsEmpty()) return default(T);
            return source.ElementAt(_rand.Next(source.Count()));
        }
    }
}
