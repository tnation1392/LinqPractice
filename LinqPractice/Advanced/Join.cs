using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPractice.Advanced
{

    public class Department
    {
        public string Name { get; set; }
        public string Location { get; set; }
    }

    public class TestResult
    {
        public int TestId { get; set; }

        public string Status { get; set; } = "";
    }

    public class TestDefinition
    {
        public int TestId { get; set; }

        public string Name { get; set; } = "";
    }

    internal class Join
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


            List<Department> departments = new()
            {
                new Department
                {
                    Name = "QA",
                    Location = "Building 1"
                },
                new Department
                {
                    Name = "Development",
                    Location = "Building 2"
                },
                new Department
                {
                    Name = "Management",
                    Location = "Building 3"
                }
            };

            Console.WriteLine("\nDepartments:");
            foreach (var department in departments)
            {
                Console.WriteLine($"Name: {department.Name}, Location: {department.Location}");
            }

            var employeeDepartments = employees.Join(
                departments,
                e => e.Department,
                d => d.Name,
                (e, d) => new { e.Name, d.Location });

            Console.WriteLine("\nEmployee Departments:");
            foreach (var item in employeeDepartments)
            {
                Console.WriteLine($"Name: {item.Name}, Location: {item.Location}");
            }

            List<TestDefinition> testDefinitions = new()
            {
                new TestDefinition
                {
                    TestId = 1,
                    Name = "Test A"
                },
                new TestDefinition
                {
                    TestId = 2,
                    Name = "Test B"
                },
                new TestDefinition
                {
                    TestId = 3,
                    Name = "Test C"
                }


            };

            Console.WriteLine("\nTest Definitions:");
            foreach (var item in testDefinitions)
            {
                Console.WriteLine($"Id: {item.TestId}, Name: {item.Name}");
            }

            List<TestResult> testResults = new()
            {
                new TestResult
                {
                    TestId = 1,
                    Status = "Pass"
                },
                new TestResult
                {
                    TestId = 2,
                    Status = "Fail"
                },
                new TestResult
                {
                    TestId = 3,
                    Status = "Pass"
                }
            };

            Console.WriteLine("\nTest Results:");
            foreach (var item in testResults)
            {
                Console.WriteLine($"Id: {item.TestId}, Status: {item.Status}");
            }

            var testResultsWithNames = testResults.Join(
                testDefinitions,
                tr => tr.TestId,
                td => td.TestId,
                (tr, td) => new { td.Name, tr.Status });

            Console.WriteLine("\nTest Results with Names:");
            foreach (var item in testResultsWithNames)
            {
                Console.WriteLine($"Name: {item.Name}, Status: {item.Status}");
            }
        }
    }
}

