using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPractice
{
    public class TestResult2
    {
        public string Name { get; set; } = "";
        public string Status { get; set; } = "";
    }
    internal class Last
    {
        public static void Run()
        {
            List<TestResult2> results = new()
            {
                new TestResult2
                {
                    Name = "LoginTest",
                    Status = "Passed"
                },

                new TestResult2
                {
                    Name = "ApiTest",
                    Status = "Failed"
                },

                new TestResult2
                {
                    Name = "CheckoutTest",
                    Status = "Failed"
                }

            };

            var lastFailedTest = results.Last(n => n.Status == "Failed");
            Console.WriteLine($"Last failed test: {lastFailedTest.Name}");
        }
    }
}
