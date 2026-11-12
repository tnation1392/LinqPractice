using System.Linq;

public static class GenLinqPractice
{
    public static void Run()
    {
        // Exercise 1
        List<int> scores = new()
        {
            65,
            72,
            88,
            91,
            55,
            100,
            79
        };

        var passingScores = scores.Where(s => s >= 80);

        Console.WriteLine("Passing scores (80 and above):");

        foreach (var score in passingScores)
        {
            Console.WriteLine($"Score: {score}");
        }

        // Exercise 1 Challenge
        List<string> testNames = new()
        {
            "LoginTest",
            "CheckoutTest",
            "ApiTest",
            "RegistrationTest",
            "ApiHealthCheck"
        };

        var apiTests = testNames.Where(name => name.Contains("Api"));

        Console.WriteLine("\nAPI-related test names:");

        foreach (var testName in apiTests)
        {
            Console.WriteLine($"Test Name: {testName}");
        }

        // Exercise 2
        List<string> names = new()
        {
            "Alice",
            "Bob",
            "Amanda",
            "Brian",
            "Andrew"
        };

        var namesStartingWithA =
            names.Where(name => name.StartsWith("A"));

        Console.WriteLine("\nNames starting with 'A':");

        foreach (var name in namesStartingWithA)
        {
            Console.WriteLine($"Name: {name}");
        }
    }
}