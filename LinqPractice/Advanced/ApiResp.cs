using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPractice.Advanced
{

    public class ApiResponse
    {
        public string Endpoint { get; set; } = "";

        public int StatusCode { get; set; }

        public int ResponseTime { get; set; }
    }

    internal class ApiResp
    {
        public static void Run()
        {
            List<ApiResponse> responses = new()
            {
                new ApiResponse
                {
                    Endpoint = "/users",
                    StatusCode = 200,
                    ResponseTime = 150
                },
                new ApiResponse
                {
                    Endpoint = "/orders",
                    StatusCode = 500,
                    ResponseTime = 1200
                },
                new ApiResponse
                {
                    Endpoint = "/products",
                    StatusCode = 404,
                    ResponseTime = 700
                },
                new ApiResponse
                {
                    Endpoint = "/health",
                    StatusCode = 200,
                    ResponseTime = 50
                }
            };
            //Find failed API responses (status code >= 400)
            var failedResponses =
                responses.Where(r => r.StatusCode >= 400);
            //Count failed API responses
            int failedCount =
                responses.Count(r => r.StatusCode >= 400);

            bool allSuccessful = responses.All(r => r.StatusCode < 400);
            Console.WriteLine($"\nAll responses successful: {allSuccessful}");

            bool hasFailures = failedResponses.Any();
            Console.WriteLine($"\nHas failures: {hasFailures}");
            Console.WriteLine($"\nNumber of failed API responses: {failedCount}");

            foreach(var response in failedResponses)
            {
                Console.WriteLine($"\nEndpoint: {response.Endpoint}, Status Code: {response.StatusCode}, Response Time: {response.ResponseTime}ms");
            }



        }
    }
}
