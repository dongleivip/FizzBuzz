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
    }
}