using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Text;
using System.Xml.Linq;
using System.Linq;

namespace LinqPractice.QAAutomation
{
    public class TestResult
    {
        public string Name { get; set; } = "";

        public string Status { get; set; } = "";

        public int Duration { get; set; }
    }
    internal class FailReport
    {
        public static void Run()
        {
            List<TestResult> results = new()
            {
                new TestResult
                {
                    Name = "LoginTest",
                    Status = "Passed",
                    Duration = 2
                },

                new TestResult
                {
                    Name = "ApiTest",
                    Status = "Failed",
                    Duration = 5
                },

                new TestResult
                {
                    Name = "CheckoutTest",
                    Status = "Passed",
                    Duration = 3
                },

                new TestResult
                {
                    Name = "RegistrationTest",
                    Status = "Failed",
                    Duration = 6
                }
            };

            //Find failed tests
            var failedTests =
                results.Where(r => r.Status == "Failed");

            //Count failed tests
            int failedCount =
                results.Count(r => r.Status == "Failed");

            Console.WriteLine("$Number of failed tests: {failedCount}");

            //Do failures exist?
            bool hasFailures =
                results.Any(r => r.Status == "Failed");

            //Failed test names
            var failedNames =
                results
                    .Where(r => r.Status == "Failed")
                    .Select(r => r.Name);

            Console.WriteLine("\nNames of failed tests: ");
            foreach (var test in failedNames)
                {
                Console.WriteLine(test);
                }
        }
    }
}
