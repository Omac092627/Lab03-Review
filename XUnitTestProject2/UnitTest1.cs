using System;
using Xunit;
using static SystemIO.Program;

namespace XUnitTestProject2
{
    public class UnitTest1
    {



        [Fact]
        public void CanReturnZero()
        {
            //arrange
            string input = "This is a string";
            //act
            int outputFromMethod = canReturnInputNumber(input);
            //assert
            Assert.Equal(0, outputFromMethod);
        }

        [Theory]
        [InlineData("4 5 1", 20)]
        [InlineData("4 5 2 9", 40)]
        [InlineData("4 5 cat", 20)]
        [InlineData("dogs are better than cats", 1)]
        [InlineData("10 -5 4", -200)]

        public void TestChallenge1(string words, int product)
        {
            //Arrange


            //Act
            int results = canReturnInputNumber(words);

            //Assert
            Assert.Equal(product, results);
        }

        [Fact]
        public void TestTwo()
        {
            int[] numbersArray = new int[] { 5, 4, 8 };
            decimal expected = 5 + 4 + 8;
            decimal average = expected / 3;
            decimal results = ChallengeTwo(numbersArray);
            Assert.Equal(average, results);
        }

        [Fact]
        public void TestChallengeTwo()
        {
            int[] numbersArray = new int[] { 0, 0, 0 };
            decimal expected = 0 + 0 + 0;
            decimal average = expected / 3;
            decimal results = ChallengeTwo(numbersArray);
            Assert.Equal(average, results);

        }
    }
}

