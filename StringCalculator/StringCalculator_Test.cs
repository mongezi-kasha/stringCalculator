using System;
using Xunit;

namespace StringCalculator
{
    public class StringCalculator_Test
    {
       //first
      [Fact]
      public void Return0EmptyString()
        {
            var calculator = new StringCalc();
            var result = calculator.Add("");
            Assert.Equal(0, result);
        }


        //Second
        [Theory]
        [InlineData("1", 1)]
        public void Return1GivenStringwith1(string numbers, int expectedResult)
        {
            var calculator = new StringCalc();
            var result = calculator.Add(numbers);
            Assert.Equal(expectedResult, result);
        }

        //Third
        [Theory]
        [InlineData("2", 2)]
        public void Return2GivenStringwith2(string numbers, int expectedResult)
        {
            var calculator = new StringCalc();
            var result = calculator.Add(numbers);
            Assert.Equal(expectedResult, result);
        }

        //fouth
        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("2,3", 5)]
        public void ReturnSumGivenStringwith2CommaSeparatedNumbers(string numbers, int expectedResult)
        {
            var calculator = new StringCalc();

            var result = calculator.Add(numbers);
            Assert.Equal(expectedResult, result);
        }

        //5th st2
        [Theory]
        [InlineData("1,2,3", 6)]
        [InlineData("2,3,3", 9)]
        public void ReturnSumGivenStringwith3CommaSeparatedNumbers(string numbers, int expectedResult)
        {
            var calculator = new StringCalc();

            var result = calculator.Add(numbers);
            Assert.Equal(expectedResult, result);
        }

        //5th st2
        [Theory]
        [InlineData("//;\n1;2;3", 6)]
        public void ReturnSumGivenStringwith3CommaOrNewLineSeparatedNumbers(string numbers, int expectedResult)
        {
            var calculator = new StringCalc();

            var result = calculator.Add(numbers);
            Assert.Equal(expectedResult, result);
        }

        //5th st2
        [Theory]
        [InlineData("-1,2", "Negetives not allowed: -1")]
        public void ThrowsGivenNegetiveInput(string numbers, string expectedMessage)
        {
            var calculator = new StringCalc();

            Action action= () => calculator.Add(numbers);

            var ex = Assert.Throws<Exception>(action);
            Assert.Equal(expectedMessage, ex.Message);
        }
    }
}
