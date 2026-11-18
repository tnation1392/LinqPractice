using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPractice.Advanced
{
    internal class Duplicates
    {
        public static void Run()
        {
            List<string> names = new()
            {
                "Alice",
                "Bob",
                "Charlie",
                "Alice",
                "David",
                "Bob"
            };
            //Find duplicate names
            var duplicateNames =
                names.GroupBy(n => n)
                     .Where(g => g.Count() > 1)
                     .Select(g => g.Key);
            Console.WriteLine("\nDuplicate names:");
            foreach (var name in duplicateNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
