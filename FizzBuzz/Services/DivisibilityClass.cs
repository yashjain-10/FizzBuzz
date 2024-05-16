namespace FizzBuzz.Services
{
    public class DivisibilityClass : IDivisibilityClass
    {
        public string CheckDivisibility(int value)
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