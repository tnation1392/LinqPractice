using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPractice
{
    internal class First
    {
        public static void Run()
        {
            //Exercise 1
            List<int> responseTimes = new()
            {
                50,
                120,
                300,
                600,
                150
            };

            var firstResponseTime = responseTimes.First(n => n > 200);
            Console.WriteLine($"First response time greater than 200: {firstResponseTime}");
        }
    }
}
