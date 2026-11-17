using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPractice.Advanced
{
    internal class GroupJoin
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

            var DepartmentGroups = employees.GroupBy(e => e.Department);
            Console.WriteLine("\nDepartment Groups:");
            foreach (var group in DepartmentGroups)
            {
                Console.WriteLine($"Department: {group.Key}");
                foreach (var employee in group)
                {
                    Console.WriteLine($"  - {employee.Name}");
                }
            }
        }

    }
}
