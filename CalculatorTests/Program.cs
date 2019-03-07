using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace CalculatorTests.Tests
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class CalculatorOperations
    {
        public int SumThis(int[] numbers)
        {
            return numbers.Sum();
        }

        public int SubtractThis(int[] numbers)
        {
            int total = 0;
            int firstValue = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            return firstValue - total;
        }

        public int MultiplyThis(int[] numbers)
        {
            var product = numbers.Aggregate(1, (acc, val) => acc * val);
            return product;
        }

        public int DivideThis(int num1, int num2)
        {
            return num1 / num2;
        }
    }

}

