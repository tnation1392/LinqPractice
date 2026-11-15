using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPractice
{
    internal class lambda
    {
        public static void Run()
        {
            // Exercise 1
            List<int> numbers = new()
            {
                1,
                2,
                3,
                4,
                5,
                6
            };
            
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("Even Numbers:");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }

            // Exercise 2
            List<string> environments = new()
            {
                "Dev",
                "QA",
                "Prod",
                "QA",
                "Dev"
            };

            var qaEnvironments = environments.Where(env => env == "QA");
            Console.WriteLine("\nQA Environments:");
            foreach (var env in qaEnvironments)
            {
                Console.WriteLine(env);
            }

        }
    }
}
