using System;
using System.Linq;
using System.Collections.Generic;

namespace Sort
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var sortClass = new SortClass();

            sortClass.GetSort();
        }
    }

    class SortClass
    {
        public void GetSort()
        {
            var source = new[] {
                new { Name = "Oliver", Age = 20 },
                new { Name = "Jacob", Age = 17 },
                new { Name = "Samantha", Age = 32 },
                new { Name = "Emma", Age = 23 },
                new { Name = "Thomas", Age = 17 },
            };

            // OrderBy()
            // Sort in ascending order
            var friend1 = source.OrderBy(n => n.Age);
            foreach (var name1 in friend1)
                Console.WriteLine(name1);
            Console.WriteLine();

            // OrderByDescending()
            // Sort in descending order
            var friend2 = source.OrderByDescending(e => e.Age);
            foreach (var name2 in friend2)
                Console.WriteLine(name2);
            Console.WriteLine();

            // ThenBy()
            // Sort in ascending order, with priority given to elements with equal keys
            var friend3 = source.OrderBy(e => e.Age).ThenBy(n => n.Name.Length);
            foreach (var name3 in friend3)
                Console.WriteLine(name3);
            Console.WriteLine();

            // ThenByDescending()
            // Sort in descending order, with priority given to elements with equal keys
            var friend4 = source.OrderBy(e => e.Age).ThenByDescending(n => n.Name.Length);
            foreach (var name4 in friend4)
                Console.WriteLine(name4);
            Console.WriteLine();

            // Reverse()
            // Sort in reverse order
            var friend5 = source.Reverse();
            foreach (var name5 in friend5)
                Console.WriteLine(name5);
            Console.WriteLine();
        }
    }
}