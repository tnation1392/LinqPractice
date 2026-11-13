using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqPractice
{

    public class ApiRequest
    {
        public string Endpoint { get; set; } = "";
        public int ResponseTime { get; set; }
    }
    internal class OrderbyDesc
    {
        public static void Run()
        {
            List<ApiRequest> requests = new()
                {
                    new ApiRequest
                    {
                        Endpoint = "/users",
                        ResponseTime = 200
                    },

                    new ApiRequest
                    {
                        Endpoint = "/orders",
                        ResponseTime = 1500
                    },

                    new ApiRequest
                    {
                        Endpoint = "/products",
                        ResponseTime = 850
                    }
                };

            var sortedRequests =
            requests.OrderByDescending(request => request.ResponseTime);

            Console.WriteLine("\nTests Sorted By Response Time:");

            foreach (var request in sortedRequests)
            {
                Console.WriteLine($"{request.Endpoint} - {request.ResponseTime}");
            }
        }
        
    }
}
