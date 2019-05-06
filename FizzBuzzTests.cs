using System;
using Xunit;

namespace FizzBuzz
{
    public class FizzBuzzTests
    {
        FizzBuzzGame game;

        public FizzBuzzTests()
        {
            game = new FizzBuzzGame();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void ShouldSayNumber(int number)
        {
            var actual = game.Count(number);

            Assert.Equal(number.ToString(), actual);
        }


        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void ShouldSayFizzWhenNumberIsDivisibleByThree(int number)
        {
            var actual = game.Count(number);

            Assert.Equal("Fizz", actual);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldSayBuzzWhenNumberIsDivisbleByFive(int number)
        {
            var actual = game.Count(number);

            Assert.Equal("Buzz", actual);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        public void ShouldSayFizzBuzzWhenDivisbleByBothThreeAndFive(int number)
        {
           var actual = game.Count(number);

            Assert.Equal("FizzBuzz", actual); 
        }
    }
}