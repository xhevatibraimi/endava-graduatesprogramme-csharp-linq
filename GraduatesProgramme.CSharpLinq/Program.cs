using System;
using System.Collections.Generic;
using System.Linq;

namespace GraduatesProgramme.CSharpLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            //var enumerator = numbers.GetEnumerator();           
            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current);
            //}

            //var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(numbers);
            //}

            IEnumerable<double> numbers = new List<double> { 1, 2.3, 2.6, 3, 4, 5, 6, 7, 8, 16, 18, 20, 24, 25, 27 };
            //ListExtensions.Print(numbers);
            //numbers.PrintEven(PrintEven);
            //var results = numbers.GetEven(PrintEven);
            //Func<int, bool> isEven = number => number % 2 == 0;
            //var results = numbers.GetEven(n => n % 2 == 0);
            //var results = numbers.Filter(n => n % 2 == 0);
            //var results = numbers.Filter(n => n % 2 == 1);
            //var results = numbers.Filter(n => n >= 2.5);
            //var results = numbers.Where(n => n >= 2.5);
            //var results = numbers
            //    .Where(x => x >= 18)
            //    .Where(x => x % 2 == 0)
            //    .Select(n => n * n)
            //    .Select(x=> Math.Sqrt(x))
            //var result = numbers.OrderByDescending(x => x);

            //var result = numbers.Sum();
            //var result = numbers.Sum(n => n * n);
            //var result = numbers.Count();
            //var result = numbers.Count(x => x >= 18);
            //var result = numbers.Any();
            //var result = numbers.Any(x=>x>=20);
            //var result = numbers.Any();
            //var results = numbers.All(x => x >= 1);
            //var result = numbers.Any(x=>x >= 40);
            //var result = numbers.First(); // this one throws exception if there are no elements in the collection
            //var result = numbers.First(x=>x >= 40); // this one throws exception if there are no elements in the collection
            //var result = numbers.FirstOrDefault();
            //var result = numbers.FirstOrDefault(x => x > 40);

            //Console.WriteLine(result);

            //var results = numbers.Skip(12).Take(10);
            //foreach (var item in results)
            //{
            //    Console.WriteLine(item);
            //}
        }

        //static bool PrintEven(int number)
        //{
        //    return number % 2 == 0;
        //}
    }
}
