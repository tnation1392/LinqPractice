using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LinqPractice.Project
{

    public class TestResult
    {
        public string TestName { get; set; }
        public string Feature { get; set; }
        public bool Passed { get; set; }
        public double ExecutionTime { get; set; }
    }
    internal class Main
    {
        public static void Run()
        {
           var TestResults =new List<TestResult>
            {
                new TestResult { TestName = "LoginTest", Feature = "Authentication", Passed = true, ExecutionTime = 1.2 },
                new TestResult { TestName = "LogoutTest", Feature = "Authentication", Passed = true, ExecutionTime = 0.8 },
                new TestResult { TestName = "AddToCartTest", Feature = "ShoppingCart", Passed = false, ExecutionTime = 2.5 },
                new TestResult { TestName = "CheckoutTest", Feature = "ShoppingCart", Passed = true, ExecutionTime = 3.1 },
                new TestResult { TestName = "SearchTest", Feature = "Search", Passed = false, ExecutionTime = 1.5 }
            };

            //Total Tests
            int totalTests = TestResults.Count();
            Console.WriteLine($"Total Tests: {totalTests}");
           

            //Finding Passed Tests
            int passedTests = TestResults.Count(t => t.Passed);
            Console.WriteLine($"\nPassed Tests: {passedTests}");

            //Finding Failed Tests
            int failedTests = TestResults.Count(t => !t.Passed);
            Console.WriteLine($"\nFailed Tests: {failedTests}");
           
            //Pass Rate
            double passRate = (double)passedTests / totalTests * 100;
            Console.WriteLine($"\nPass Rate: {passRate}%");

            //Failed Test List
            var failures = TestResults
                .Where(t => !t.Passed)
                .Select(t => t.TestName)
                .ToList();

            foreach (var failure in failures)
            {
                Console.WriteLine($"\nFailed Test: {failure}");
            }

            //Failures by Feature
            var failuresByFeature = TestResults
                .Where(t => !t.Passed)
                .GroupBy(t => t.Feature)
                .Select(g => new { Feature = g.Key, Count = g.Count() })
                .ToList();

            Console.WriteLine($"\nFailures by Feature:");
            foreach (var failure in failuresByFeature)
            {
                Console.WriteLine($"  {failure.Feature}: {failure.Count}");
            }

            //Highest Risk Feature
            var highestRiskFeature = failuresByFeature
                .Where(f => f.Count > 0)
                .GroupBy(f => f.Feature)
                .OrderByDescending(f => f.Count())
                .First();
            Console.WriteLine($"\nHighest Risk Feature: {highestRiskFeature.Key}");

            //Average Execution Time
            double averageExecutionTime = TestResults.Average(t => t.ExecutionTime);
            Console.WriteLine($"\nAverage Execution Time: {averageExecutionTime:F2} seconds");

            //Slowest Execution Time
            var slowestTest = TestResults
                .OrderByDescending(t => t.ExecutionTime)
                .First();
            Console.WriteLine($"\nSlowest Test: {slowestTest.TestName} ({slowestTest.ExecutionTime} seconds)");
        }
    }
}
