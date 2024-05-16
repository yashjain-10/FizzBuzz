using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz.Services
{
    public interface IFizzBuzzFunction
    {
        List<string> GetFizzBuzz(List<string> list);
    }
}