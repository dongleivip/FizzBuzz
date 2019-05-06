namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public string Count(int number) {

            if(number % 3 == 0) {
                return "Fizz";
            }

            return number.ToString();
        }
    }
}