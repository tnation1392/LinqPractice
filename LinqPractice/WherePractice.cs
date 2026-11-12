using System.Linq;

namespace LinqPractice
{
    public class TestResult
    {
        public string Name { get; set; } = "";
        public string Status { get; set; } = "";
    }

    internal class WherePractice
    {
        public static void Run()
        {
            // Exercise 1
            List<int> statusCodes = new()
            {
                200,
                200,
                404,
                500,
                200,
                503
            };

            var failures =
                statusCodes.Where(code => code >= 400);

            Console.WriteLine("Failures:");

            foreach (var failure in failures)
            {
                Console.WriteLine(failure);
            }

            // Exercise 2
            List<TestResult> results = new()
            {
                new TestResult
                {
                    Name = "LoginTest",
                    Status = "Passed"
                },

                new TestResult
                {
                    Name = "CheckoutTest",
                    Status = "Failed"
                },

                new TestResult
                {
                    Name = "ApiTest",
                    Status = "Failed"
                }
            };

            var failedTests =
                results.Where(test => test.Status == "Failed");

            Console.WriteLine("\nFailed Tests:");

            foreach (var test in failedTests)
            {
                Console.WriteLine(test.Name);
            }
        }
    }
}
