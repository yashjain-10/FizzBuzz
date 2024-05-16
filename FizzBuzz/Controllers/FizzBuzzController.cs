using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz.Services;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FizzBuzzController : ControllerBase
    {
        private readonly IFizzBuzzFunction finalFizzBuzz;

        public FizzBuzzController()
        {
            finalFizzBuzz = new FizzBuzzFunction();
        }

        public FizzBuzzController(IFizzBuzzFunction _finalFizzBuzz)
        {
            finalFizzBuzz = _finalFizzBuzz;
        }

        [HttpPost]
        public ActionResult GetFizzBuzz([FromBody] List<string> values)
        {
            var result = finalFizzBuzz.GetFizzBuzz(values);
            return Ok(result);
        }
    }
}