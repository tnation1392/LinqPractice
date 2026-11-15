using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPractice.Foundational
{
    internal class All
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
            bool allGreaterThanZero = numbers.All(n => n > 0);
            Console.WriteLine($"All numbers greater than zero: {allGreaterThanZero}");

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
                    Status = "Passed"
                },
                new TestResult4
                {
                    Name = "ApiTest",
                    Status = "Passed"
                }
            };
            bool allTestsPassed = results.All(r => r.Status == "Passed");
            Console.WriteLine($"All tests passed: {allTestsPassed}");
        }
    }
}
