using System;
using Xunit;
using System.Collections.Generic;
using CalculatorTests.Tests;
using System.Linq.Expressions;

namespace TestingOperations.Tests
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 15)]
        [InlineData(new int[] { 1, 5, 10, 15, 20 }, 51)]
        [InlineData(new int[] { 738729, 8372830, 27568, 8392948 }, 17532075)]

        public void Sum(int[] numbers, int expected)
        {
            var arraySolver = new CalculatorOperations();

            int actual = arraySolver.SumThis(numbers);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, -13)]
        [InlineData(new int[] { 1, 5, 10, 15, 20 }, -49)]
        [InlineData(new int[] { 738729, 8372830, 27568, 8392948 }, -16054617)]

        public void Subtract(int[] numbers, int expected)
        {
            var arraySolver = new CalculatorOperations();

            int actual = arraySolver.SubtractThis(numbers);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 5, 7, 9 }, 630)]
        [InlineData(new int[] { 2, 5, 6, 70, 1000, 0 }, 0)]
        [InlineData(new int[] { 40, 25, 2, 30 }, 60000)]
        public void Multiply(int[] numbers, int expected)
        {
            var arraySolver = new CalculatorOperations();

            int actual = arraySolver.MultiplyThis(numbers);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData( 50, 5, 10)]
        [InlineData(103242134, 2 , 51621067)]
        public void Divide(int num1, int num2 , int expected)
        {
            var arraySolver = new CalculatorOperations();

            int actual = arraySolver.DivideThis(num1, num2);

            Assert.Equal(expected, actual);
        }
    }
}
