using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPractice
{
    public class TestResult5
    {
        public string Name { get; set; } = "";
        public string Status { get; set; } = "";
    }
    internal class Chaining
    {
        public static void Run()
        {
            //Exercise 1
            List<int> ResponseTime = new()
            {
                50,
                120,
                300,
                600,
                150,
                80
            };

            var result = ResponseTime
                .Where(n => n > 100)
                .OrderBy(n => n)
                .Take(3);

            Console.WriteLine("Top 3 response times greater than 100ms:");
            foreach (var time in result)
            {
                Console.WriteLine(time);
            }

            //Exercise 2
            List<TestResult5> results = new()
            {
                new TestResult5
                {
                    Name = "LoginTest",
                    Status = "Passed"
                },
                new TestResult5
                {
                    Name = "CheckoutTest",
                    Status = "Failed"
                },
                new TestResult5
                {
                    Name = "ApiTest",
                    Status = "Passed"
                },
                new TestResult5
                {
                    Name = "PaymentTest",
                    Status = "Failed"
                }
            };

            var failedTests = results
                .Where(r => r.Status == "Failed")
                .OrderBy(r => r.Name)
                .Select(r => r.Name);

            Console.WriteLine("\nFailed Tests:\n");
            foreach (var testName in failedTests)
            {
                Console.WriteLine(testName);
            }
        }
    }
}
