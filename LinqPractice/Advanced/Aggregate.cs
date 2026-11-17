using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPractice.Advanced
{
    internal class Aggregate
    {
        public static void Run()
        {
            List<Employee> employees = new()
            {
                new Employee
                {
                    Name = "Todd",
                    Department = "QA"
                },
                new Employee
                {
                    Name = "Alex",
                    Department = "QA"
                },
                new Employee
                {
                    Name = "Kim",
                    Department = "Development"
                },
                new Employee
                {
                    Name = "Casey",
                    Department = "Management"
                }
            };
            Console.WriteLine("\nEmployees:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"Name: {employee.Name}, Department: {employee.Department}");
            }
            var concatenatedNames = employees.Aggregate("", (acc, e) => acc + e.Name + ", ");
            Console.WriteLine($"\nConcatenated Names: {concatenatedNames.TrimEnd(',', ' ')}");

            //Exercise 2
            List<int> numbers = new() 
            { 100,
              150,
              200,
              250};

            var sum = numbers.Aggregate((acc, n) => acc + n);
            Console.WriteLine($"\nSum of Numbers: {sum}");
        }
    }
}
