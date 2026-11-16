using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPractice.WorkonObj
{
    public class TestResult
    {
        public string Name { get; set; } = "";
        public int Duration { get; set; }
    }
    internal class Aggregating
    {
        public static void Run()
        {
            List<TestResult> results = new()
{
    new TestResult
    {
        Name = "LoginTest",
        Duration = 4
    },

    new TestResult
    {
        Name = "ApiTest",
        Duration = 2
    },

    new TestResult
    {
        Name = "CheckoutTest",
        Duration = 8
    }
};
            //Sum of all test durations
            var totalDuration = results.Sum(r => r.Duration);
            Console.WriteLine($"\nTotal Test Duration: {totalDuration}s");

            //Average test duration
            var averageDuration = results.Average(r => r.Duration);
            Console.WriteLine($"\nAverage Test Duration: {averageDuration:F2}s");

            //Longest test duration
            var longestTest = results.Max(r => r.Duration);
            Console.WriteLine($"\nLongest Test Duration: {longestTest}s");

            //Shortest test duration
            var shortestTest = results.Min(r => r.Duration);
            Console.WriteLine($"\nShortest Test Duration: {shortestTest}s");
        }
    }
}
