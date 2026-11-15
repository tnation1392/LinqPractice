using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPractice.WorkonObj
{


    internal class AnonTypes
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
                    YearsOfService = 4
                }
            };

            var EmployeeReport = results
                .Select(e => new { e.Name, 
                                   e.Department,
                                   e.YearsOfService });

            Console.WriteLine("Employee Report:");
            foreach (var employee in EmployeeReport)
            {
                Console.WriteLine($"Name: {employee.Name} - {employee.Department}, - {employee.YearsOfService} years");
            }
        }
    }
}
