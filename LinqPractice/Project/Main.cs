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
            Console.WriteLine($"Passed Tests: {passedTests}");

            //Finding Failed Tests
            int failedTests = TestResults.Count(t => !t.Passed);
            Console.WriteLine($"Failed Tests: {failedTests}");
           
        }
    }
}
