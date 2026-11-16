using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPractice.WorkonObj
{

    public class EmployeeReport
    {
        public string Name { get; set; } = "";

        public string ExperienceLevel { get; set; } = "";
    }
    internal class AdvFilter
    {
        public static void Run()
        {
            //Exercise 1
            List<Employee> results = new()
            {
                new Employee
                {
                    Id = 1,
                    Name = "Todd",
                    Department = "Technician",
                    YearsOfService = 3
                },
                new Employee
                {
                    Id = 2,
                    Name = "Kim",
                    Department = "Analyst",
                    YearsOfService = 5
                },
                new Employee
                {
                    Id = 3,
                    Name = "Casey",
                    Department = "Management",
                    YearsOfService = 7
                },
                new Employee
                {
                    Id = 4,
                    Name = "Alex",
                    Department = "Technician",
                    YearsOfService = 5
                }
            };
            var EmployeeReport = results
                .Where(e => e.Department == "Technician" 
                        && e.YearsOfService > 4)
                .Select(e => new EmployeeReport
                {
                    Name = e.Name,
                    ExperienceLevel = e.YearsOfService > 5 ? "Senior" : "Junior"
                });
            Console.WriteLine("Employee Report:");
            foreach (var employee in EmployeeReport)
            {
                Console.WriteLine($"Name: {employee.Name} - {employee.ExperienceLevel}");
            }
        }
    }
}
