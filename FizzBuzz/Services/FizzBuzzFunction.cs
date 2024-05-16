namespace FizzBuzz.Services
{
    public class FizzBuzzFunction : IFizzBuzzFunction
    {

        private readonly IDivisibilityClass _divisibilityClass;

        public FizzBuzzFunction(IDivisibilityClass divisibilityClass)
        {
            _divisibilityClass = divisibilityClass;
        }

        public List<string> GetFizzBuzz(List<string> values)
        {
            List<string> finalResult = new();

            foreach (var value in values)
            {
                if (int.TryParse(value, out int intValue))
                {
                    string result = _divisibilityClass.CheckDivisibility(intValue);
                    finalResult.Add(result);
                }
                else
                {
                    finalResult.Add("invalid input");
                }
            }

            return finalResult;
        }
    }
}