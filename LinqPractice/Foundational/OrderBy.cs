using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LinqPractice
{
    internal class OrderByPractice
    {
        public class TestResult
        {
            public string Name { get; set; } = "";
            public int Duration { get; set; }
        }
        public static void Run()
        {
            //Exercise 1
            List<int> scores = new()
            {
                88,
                72,
                100,
                55,
                91
            };

            var sortedNumbers =
                scores.OrderBy(num => num);

            Console.WriteLine("Sorted Scores:");

            foreach (var score in sortedNumbers)
            {
                Console.WriteLine(score);
            };

            //Exercise 2
            List<TestResult> tests = new()
            {
                new TestResult
                {
                    Name = "Login Test",
                    Duration = 4
                },

                new TestResult
                {
                    Name = "Checkout Test",
                    Duration = 8
                },

                new TestResult
                {
                    Name = "ApiTest",
                    Duration = 2
                }
            };

            var SortedTests = tests.OrderBy(tests => tests.Duration);

            Console.WriteLine("\nTests Sorted By Duration:");

            foreach (var test in SortedTests)
            {
                Console.WriteLine($"{test.Name} - {test.Duration}s");
            }




        }
        
       
    }
}