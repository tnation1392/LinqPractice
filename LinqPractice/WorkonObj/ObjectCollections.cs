using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPractice.WorkonObj
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public string Department { get; set; } = "";

        public int YearsOfService { get; set; }
    }

    internal class ObjectCollections
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
                }
                new Employee
                {
                    Id = 4,
                    Name = "Alex",
                    Department = "Technician",
                    YearsOfService = 4
                }
            };
            
            var technicianEmployees = results.Where(e => e.Department == "Technician");

            foreach (var employee in technicianEmployees)
            {
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Department: {employee.Department}, Years of Service: {employee.YearsOfService}");
            })

        }
    }
}
