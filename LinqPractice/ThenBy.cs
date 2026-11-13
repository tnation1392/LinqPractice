using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPractice
{
    public class Emp
    {
        public string Name { get; set; } = "";
        public string Department { get; set; } = "";
    }

    internal class ThenBy
    {
        public static void Run()
        {
            List<Emp> employees = new()
            {
                new Emp
                {
                    Name = "Todd",
                    Department = "Tech"
                },
                new Emp
                {
                    Name = "Kim",
                    Department = "Analyst"
                },
                new Emp
                {
                    Name = "Alex",
                    Department = "Tech"
                },
                new Emp
                {
                    Name = "Casey",
                    Department = "Lead"
                }
            };

            var sortedEmployees =
                employees.OrderBy(emp => emp.Department)
                         .ThenBy(emp => emp.Name);

            Console.WriteLine("Employees Sorted By Department and Name:");

            foreach (var employee in sortedEmployees)
            {
                Console.WriteLine($"{employee.Name} - {employee.Department}");
            }

        }
    }
}
