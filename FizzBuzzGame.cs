namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public string Count(int number) {

            var result = "";

            if(number % 3 == 0) {
                result += "Fizz";
            }

            if (number % 5 == 0) {
                result += "Buzz";
            }

            return result.Length > 0 ? result : number.ToString();
        }
    }
}