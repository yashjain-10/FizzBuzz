using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz.Services
{
    public class FizzBuzzFunction : IFizzBuzzFunction
    {
        // private readonly ILogger<FizzBuzzFunction> _logger;

        // public FizzBuzzFunction(ILogger<FizzBuzzFunction> logger)
        // {
        //     _logger = logger;
        // }

        public List<string> GetFizzBuzz(List<string> values)
        {
            Console.WriteLine("Going in");
            List<string> finalResult = new();

            foreach (var value in values)
            {
                if (int.TryParse(value, out int intValue))
                {
                    string result = CheckDivisibility(intValue);
                    // _logger.LogInformation(result);
                    finalResult.Add(result);
                }
                else
                {
                    finalResult.Add("invalid input");
                }
            }

            return finalResult;
        }

        static private string CheckDivisibility(int value)
        {
            if (value % 15 == 0)
                return $"FizzBuzz";
            else if (value % 3 == 0)
                return "Fizz";
            else if (value % 5 == 0)
                return "Buzz";
            else
                return $"Divided {value} by 3 \nDivided {value} by 5";
        }
    }
}