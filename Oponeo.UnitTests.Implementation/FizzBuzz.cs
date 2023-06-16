using System.Text.Json;

namespace Oponeo.UnitTests.Implementation
{
    public class FizzBuzz
    {

        public string CalculateFizzBuzzForNumber(int integer)
        {
            var buffer = string.Empty;
            if (integer % 3 == 0)
            {
                buffer += "Fizz";
            }
            if (integer % 5 == 0)
            {
                buffer += "Buzz";
            }

            if(string.IsNullOrWhiteSpace(buffer))
            {
                buffer = integer.ToString();
            }
            return buffer;
        }

    }
}