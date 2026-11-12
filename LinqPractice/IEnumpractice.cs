using System.Linq;

public static class IEnumPractice
{
    public static void Run()
    {
        //Exercise 1
        List<int> numbers = new()
        {
            10,
            20,
            30,
            40,
            50
        };

        var largeNumbers =
            numbers.Where(n => n >= 30);

        Console.WriteLine("Large Numbers:");

        foreach (var number in largeNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine();
        Console.WriteLine("Type:");

        Console.WriteLine(largeNumbers.GetType());

        //Exercise 2
        List<string> testStatuses = new()
        {
            "Passed",
            "Failed",
            "Passed",
            "Failed",
            "Passed"
        };

        var failedTests =
    testStatuses.Where(status => status == "Failed");

        Console.WriteLine("\nFailed Tests:");

        foreach (var status in failedTests)
        {
            Console.WriteLine($"Status: {status}");
        }

        Console.WriteLine();
        Console.WriteLine("Type before ToList():");

        Console.WriteLine(failedTests.GetType());

        var failedTestList = failedTests.ToList();

        Console.WriteLine();
        Console.WriteLine("Type after ToList():");

        Console.WriteLine(failedTestList.GetType());
    }
}