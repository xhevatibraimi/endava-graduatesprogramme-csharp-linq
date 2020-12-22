using System;
using System.Collections.Generic;

namespace GraduatesProgramme.CSharpLinq
{
    public static class ListExtensions
    {
        //public static void Print<T>(List<T> collection)
        //{
        //    foreach (var item in collection)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //public static void Print<T>(this List<T> collection)
        //{
        //    foreach (var item in collection)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //public static void PrintEven(this List<int> collection, Func<int, bool> isEven)
        //{
        //    foreach (var item in collection)
        //    {
        //        if (isEven(item))
        //        {
        //            Console.WriteLine(item);
        //        }
        //    }
        //}

        //public static List<int> GetEven(this List<int> collection, Func<int, bool> isEven)
        //{
        //    var results = new List<int>();
        //    foreach (var item in collection)
        //    {
        //        if (isEven(item))
        //        {
        //            results.Add(item);
        //        }
        //    }
        //    return results;
        //}

        //public static IEnumerable<int> GetEven(this List<int> collection, Func<int, bool> isEven)
        //{
        //    foreach (var item in collection)
        //    {
        //        if (isEven(item))
        //        {
        //            yield return item;
        //        }
        //    }
        //}

        //public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);
        public static IEnumerable<TSource> Filter<TSource>(this IEnumerable<TSource> collection, Func<TSource, bool> filter)
        {
            foreach (var item in collection)
            {
                if (filter(item))
                {
                    yield return item;
                }
            }
        }
    }
}
