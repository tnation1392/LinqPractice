using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPractice.Advanced
{
    internal class ToDict
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
            var employeeDictionary = employees.ToDictionary(e => e.Name, e => e.Department);
            foreach (var kvp in employeeDictionary)
            {
                Console.WriteLine($"Name: {kvp.Key}, Department: {kvp.Value}");
            }

            Console.WriteLine(employeeDictionary["Todd"]);
        }
    }
}
