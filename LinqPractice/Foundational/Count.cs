using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPractice.Foundational
{

    public class TestResult4
    {
        public string Name { get; set; } = "";
        public string Status { get; set; } = "";
    }

    internal class Count
    {
        public static void Run()
        {
            //Exercise 1
            List<int> numbers = new()
            {
                50,
                100,
                150,
                200
            };

            int count = numbers.Count(n => n > 100);
            Console.WriteLine($"Count of numbers greater than 100: {count}");

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

            int countFailedTests = results.Count(r => r.Status == "Failed");
            Console.WriteLine($"Count of failed tests: {countFailedTests}");
        }
    }
}
