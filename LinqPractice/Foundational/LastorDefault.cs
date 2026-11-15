using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPractice.Foundational
{
    public class TestRes3
    {
        public string Name { get; set; } = "";
        public string Status { get; set; } = "";
    }

    internal class LastorDefault
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

            var LastResponseTime = responseTimes.LastOrDefault(n => n > 500);
            Console.WriteLine($"Last response time greater than 500: {LastResponseTime}");

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

            var LastFail = results.LastOrDefault(n => n.Status == "Failed");
            Console.WriteLine($"Last failed test: {LastFail.Name}");






        }
    } }
