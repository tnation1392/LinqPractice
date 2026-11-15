using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPractice
{
    internal class Skip
    {public static void Run()
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
            var skippedNumbers = numbers.Skip(3);
            Console.WriteLine("Numbers after skipping the first three:");
            foreach (var number in skippedNumbers)
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
            var skippedResults = results.Skip(1);
            Console.WriteLine("Test results after skipping the first one:");
            foreach (var result in skippedResults)
            {
                Console.WriteLine($"Name: {result.Name}, Status: {result.Status}");
            }
        }
    }
}
