using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPractice
{
    internal class Distinct
    {
        public static void Run()
        {
            //Exercise 1
            List<int> responseCodes = new()
            {
                200,
                404,
                200,
                500,
                404,
                503,
                200
            };

            var distinctCodes = responseCodes.Distinct();
            Console.WriteLine("Distinct Response Codes:");
            foreach (var code in distinctCodes)
            {
                Console.WriteLine(code);
            }
        }
    }
}
