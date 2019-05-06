using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public string Count(int number) {

            var result = "";

            var digits = number.ToString().ToCharArray();

            if(number % 3 == 0 || digits.Any(x => x == '3')) {
                result += "Fizz";
            }

            if (number % 5 == 0 || digits.Any(x => x == '5')) {
                result += "Buzz";
            }

            return result.Length > 0 ? result : number.ToString();
        }
    }
}