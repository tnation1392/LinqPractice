using System.Linq;


///Exercise 1
/// A list of scores
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

// Using LINQ to filter scores that are 80 and above
var passingScores = scores.Where(s => s >= 80);

Console.WriteLine("Passing scores (80 and above):");
foreach (var score in passingScores)
{
    Console.WriteLine($"Score: {score}");
}

//Exercise 1 Challenging
//List of test names
List<string> testNames = new()
{
    "LoginTest",
    "CheckoutTest",
    "ApiTest",
    "RegistrationTest",
    "ApiHealthCheck"
};

//Using LINQ to filter test names that contain "Api"
var apiTests = testNames.Where(name => name.Contains("Api"));

Console.WriteLine("\nAPI-related test names:");
foreach (var testName in apiTests)
{
    Console.WriteLine($"Test Name: {testName}");
}

//Exercise 2
// A list of names
List <string> names = new()
{
    "Alice",
    "Bob",
    "Amanda",
    "Brian",
    "Andrew"
};

// Using LINQ to filter names that start with 'A'
var namesStartingWithA = names.Where(name => name.StartsWith("A"));

Console.WriteLine("\nNames starting with 'A':");
foreach (var name in namesStartingWithA)
{
    Console.WriteLine($"Name: {name}");
}
