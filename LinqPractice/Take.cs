using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPractice
{
    internal class Take
    {
        public static void Run()
        {
            //Exercise 1
            List<int> numbers = new()
            {
                50,
                100,
                150,
                200,
                350,
                600
            };
            var takenNumbers = numbers.Take(3);
            Console.WriteLine("First three numbers:");
            foreach (var number in takenNumbers)
            {
                Console.WriteLine(number);
            }

            //Exercise 2
            List<TestResult4> results = new()
            {
                new TestResult4
                {
                    Name = "LoginTest",
                    Status = "Passed"
                },
                new TestResult4
                {
                    Name = "CheckoutTest",
                    Status = "Failed"
                },
                new TestResult4
                {
                    Name = "ApiTest",
                    Status = "Passed"
                }
            };
            var takenResults = results.Take(2);
            Console.WriteLine("First two test results:");
            foreach (var result in takenResults)
            {
                Console.WriteLine($"Name: {result.Name}, Status: {result.Status}");
            }
        }
    }
}
