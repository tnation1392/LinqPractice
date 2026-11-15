using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqPractice
{
    public class Employee
    {
        public string Name { get; set; } = "";
        public string Department { get; set; } = "";
    }

    internal class SelectPractice
    {
        public static void Run()
        {
            // Exercise 1
            List<int> numbers = new()
            {
                5,
                10,
                15,
                20
            };

            var result10 = numbers.Select(num => num * 10);

            Console.WriteLine("Numbers x 10:");

            foreach (var number in result10)
            {
                Console.WriteLine(number);
            }

            // Exercise 2
            List<Employee> employees = new()
            {
                new Employee
                {
                    Name = "Todd",
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

            var employeeNames =
                employees.Select(employee => employee.Name);

            Console.WriteLine("\nEmployee Names:");

            foreach (var employeeName in employeeNames)
            {
                Console.WriteLine(employeeName);
            }
        }
    }
}