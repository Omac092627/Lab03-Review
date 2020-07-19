using System;
using Xunit;
using static SystemIO.Program;

namespace SystemIO
{
    public class UnitTest1
    {



        [Fact]
        public void CanReturnZero()
        {
            //arrange
            string input = "This is a string";
            //act
            int outputFromMethod = MultiplyNumber(input);
            //assert
            Assert.Equal(1, outputFromMethod);
        }

        [Fact]
        public void ReturnZeroIfLengthLessThanThree()
        {
            string input = "2 3 4";

            int output = MultiplyNumber(input);

            Assert.Equal(24, output);
        }

        [Theory]
        [InlineData("4 5 1", 20)]
        [InlineData("4 5 2 9", 40)]
        [InlineData("4 5 cat", 20)]
        [InlineData("dogs are better than cats", 1)]
        [InlineData("10 -5 4", -200)]

        public void ReturnProducts(string words, int product)
        {
            //Arrange


            //Act
            int results = MultiplyNumber(words);

            //Assert
            Assert.Equal(product, results);
        }

        [Fact]
        public void TestTwo()
        {
            int[] numbersArray = { 1, 2, 3, 4 };
            decimal expected = GetAverage(numbersArray);
            Assert.Equal(2.5m, expected);
        }


        [Theory]
        [InlineData(new int[] { 5, 6, 9, 2 }, 5.5)]
        [InlineData(new int[] { 18, 11, 1 }, 10)]
        [InlineData(new int[] { 9, 24, 33, 91, 7 }, 32.8)]
        [InlineData(new int[] { 0, 0, 0, 0 }, 0)]

        public void TestAverages(int[] numbersArray, decimal number)
        {

            //Act
            decimal output = GetAverage(numbersArray);

            //Assert
            Assert.Equal(number, output);
        }


        [Fact]
        public void ReturnExample()
        {
            int[] test = new int[] { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };

            int output = Duplicates(test);

            Assert.Equal(1, output);
        }

        [Theory]
        [InlineData(new int[] {5, 5, 5, 6, 6, 1}, 5)]
        [InlineData(new int[] {1, 1, 1, 1, 1}, 1)]
        [InlineData(new int[] {3, 3, 2, 2}, 3)]
        [InlineData(new int[] {1, 2, 3, 4}, 1)]

        public void ReturnExpected(int[] input, int output)
        {
            int method = Duplicates(input);

            Assert.Equal(output, method);
        }



        [Fact]
        public void DoesProvidedWork()
        {
            int[] inputArray = new int[] { 5, 25, 99, 123, 78, 96, 555, 108, 4 };

            int output = MaxValue(inputArray);

            Assert.Equal(555, output);
        }

        [Theory]
        [InlineData(new int[] { 1, -1, 55, -33, -100 }, 55)]
        [InlineData(new int[] { 5, 5, 5, 5 }, 5)]

        public void AllTests(int[] inputArray, int output)
        {
            int method = MaxValue(inputArray);

            Assert.Equal(output, method);
        }


        [Fact]
        public void CanIReturnStringArray()
        {
            string example = "Hello there love";

            string[] output = GetLength(example);

            Assert.Equal(new string[] { "hello: 5", "there: 5", "love: 4" }, output);
        }

        [Theory]
        [InlineData("Look Mom I made it", new string[] { "look: 4", "mom: 3", "i: 1", "made: 4", "it: 2"})]
        [InlineData("Look Mom I suck", new string[] { "look: 4", "mom: 3", "i: 1", "suck: 4"})]

        public void LastTest(string input, string[] entered )
        {
            string[] method = GetLength(input);
            Assert.Equal(entered, method);
        }

    }
}


