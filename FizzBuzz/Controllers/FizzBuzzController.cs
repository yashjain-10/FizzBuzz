using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// using FizzBuzz.Classes;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzz.Controllers;

[ApiController]
[Route("[controller]")]
public class FizzBuzzController : ControllerBase
{
    [HttpPost]
    public IActionResult FizzBuzzResults([FromBody] int[] values)
    {
        if (CheckInput(values) == 0)
        {
            return BadRequest("Invalid Input");
        }

        var finalResult = "";

        foreach (var value in values)
        {
            var result = CheckDivisibility(value);
            Console.WriteLine(result); // For debugging purposes, you may want to log the results instead of writing to the console.
            finalResult += $"{value} : {result} \n";
        }

        return Ok(finalResult);
    }

    private int CheckInput(int[] values)
    {
        if (values == null || values.Length == 0)
        {    
            Console.WriteLine("Invalid Input");
            return 0;
        }
        else
            return 1;
    }

    private string CheckDivisibility(int value)
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