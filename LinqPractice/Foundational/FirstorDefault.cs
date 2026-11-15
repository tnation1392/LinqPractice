using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPractice
{
    public class TestRes
    {
        public string Name { get; set; } = "";
        public string Status { get; set; } = "";
    }

    internal class FirstorDefault
    {
        public static void Run()
        {
            //Exercise 1
            List<int> responseTimes = new()
            {
                50,
                100,
                150,
                200
            };

            var firstResponseTime = responseTimes.FirstOrDefault(n => n > 500);
            Console.WriteLine($"First response time greater than 500: {firstResponseTime}");

            //Exercise 2
            List<TestRes> results = new()
            {
                new TestRes
                {
                    Name = "LoginTest",
                    Status = "Passed"
                },
                new TestRes
                {
                    Name = "CheckoutTest",
                    Status = "Passed"
                },
                new TestRes
                {
                    Name = "ApiTest",
                    Status = "Passed"
                }

                
            };

            var FirstFail = results.FirstOrDefault(n => n.Status == "Failed");
            Console.WriteLine($"First failed test: {FirstFail.Name}");






        }
    } }
