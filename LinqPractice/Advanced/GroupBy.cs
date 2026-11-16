using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPractice.Advanced
{
    public class Employee
    {
        public string Name { get; set; } = "";

        public string Department { get; set; } = "";
    }
    internal class GroupBy
    {
        public static void Run()
        {
            List<int> results = new()
            {
                1,
                2,
                3,
                4,
                5,
                6
            };

            var groupedResults = results.GroupBy(r => r % 2 == 0 ? "Even" : "Odd");

            foreach (var group in groupedResults)
            {
                Console.WriteLine($"\nGroup: {group.Key}");
                foreach (var number in group)
                {
                    Console.WriteLine($"Number: {number}");
                }
            }

            //Exercise 1
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

            var departmentGroups = employees.GroupBy(e => e.Department);
            foreach (var group in departmentGroups)
            {
                Console.WriteLine($"\nDepartment: {group.Key}");
                foreach (var employee in group)
                {
                    Console.WriteLine($"Employee: {employee.Name}");
                }
            }
        }
    }
}
