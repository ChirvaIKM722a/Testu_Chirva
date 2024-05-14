using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Function;

namespace Test
{


    namespace Function.Tests
    {
        [TestFixture]
        public class Function_of_testingTests
        {
            private Function_of_testing _function;

            [SetUp]
            public void Setup()
            {
                _function = new Function_of_testing();
            }

            [Test]
            public void CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
            {
                // Arrange
                int number = 5;
                int expectedFactorial = 120;

                // Act
                int result = _function.CalculateFactorial(number);

                // Assert
                Assert.AreEqual(expectedFactorial, result);
            }



            [Test]
            public void IsEven_InputEvenNumber_ReturnsTrue()
            {
                // Arrange
                int number = 6;

                // Act
                bool result = _function.IsEven(number);

                // Assert
                Assert.IsTrue(result);
            }

            [Test]
            public void IsPrime_InputPrimeNumber_ReturnsTrue()
            {
                // Arrange
                int number = 7;

                // Act
                bool result = _function.IsPrime(number);

                // Assert
                Assert.IsTrue(result);
            }

            [Test]
            public void FindMax_InputArray_ReturnsMaxValue()
            {
                // Arrange
                int[] numbers = { 3, 7, 2, 9, 5 };
                int expectedMax = 9;

                // Act
                int result = _function.FindMax(numbers);

                // Assert
                Assert.AreEqual(expectedMax, result);
            }

            [Test]
            public void FindAverage_InputArray_ReturnsCorrectAverage()
            {
                // Arrange
                int[] numbers = { 3, 6, 9 };
                double expectedAverage = 6;

                // Act
                double result = _function.FindAverage(numbers);

                // Assert
                Assert.AreEqual(expectedAverage, result);
            }

            [Test]
            public void Contains_InputArrayAndValue_ReturnsTrueIfValueExists()
            {
                // Arrange
                int[] numbers = { 1, 3, 5, 7, 9 };
                int value = 5;

                // Act
                bool result = _function.Contains(numbers, value);

                // Assert
                Assert.IsTrue(result);
            }

            [Test]
            public void ConcatenateStrings_InputTwoStrings_ReturnsConcatenatedString()
            {
                // Arrange
                string str1 = "Hello";
                string str2 = "World";
                string expectedConcatenatedString = "HelloWorld";

                // Act
                string result = _function.ConcatenateStrings(str1, str2);

                // Assert
                Assert.AreEqual(expectedConcatenatedString, result);
            }

            [Test]
            public void IsPalindrome_InputPalindromeString_ReturnsTrue()
            {
                // Arrange
                string palindrome = "racecar";

                // Act
                bool result = _function.IsPalindrome(palindrome);

                // Assert
                Assert.IsTrue(result);
            }

            [Test]
            public void CalculateSum_InputArray_ReturnsCorrectSum()
            {
                // Arrange
                int[] numbers = { 1, 2, 3, 4, 5 };
                int expectedSum = 15;

                // Act
                int result = _function.CalculateSum(numbers);

                // Assert
                Assert.AreEqual(expectedSum, result);
            }

            [Test]
            public void CalculateMedian_InputArray_ReturnsCorrectMedian()
            {
                // Arrange
                int[] numbers = { 1, 2, 3, 4, 5 };
                double expectedMedian = 3;

                // Act
                double result = _function.CalculateMedian(numbers);

                // Assert
                Assert.AreEqual(expectedMedian, result);
            }
        }
    }
}