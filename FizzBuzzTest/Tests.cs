using System;
using FizzBuzz;
using Xunit;

namespace FizzBuzzTest
{
    public class Tests
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(13, "Fizz")]
        [InlineData(75, "FizzBuzz")]
        public void ShouldReturnCorrectValue(int number, string expectValue)
        {
            Filter fizzbuzz = new FizzBuzzFilter();
            Filter buzz = new BuzzFilter();
            Filter fizz = new FizzFilter();
            Filter nop = new NoFilter();

            fizzbuzz.SetNextFilter(buzz);
            buzz.SetNextFilter(fizz);
            fizz.SetNextFilter(nop);

            var actualValue = fizzbuzz.GetValue(number);
            Assert.Equal(expectValue, actualValue);
        }
    }
}