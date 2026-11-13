using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPractice
{
    internal class Singleprac
    {
        public static void Run()
        {
            List<int> empID = new()
            {
                101,
                102,
                103
            };

            var Emp101 = empID.Single(n => n == 101);
            Console.WriteLine($"Employee searched for: {Emp101}");
        }
    }
}
