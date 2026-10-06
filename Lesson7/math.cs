using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
    internal class Math
    {

        public double Sum(double[] numbers)
        {
            double result = 0.0;
            foreach (double number in numbers)
            {
                result += number;
            }
            return result;
        }
        public int Count (double[] numbers)
        {
            return numbers.Length;
        }
        public double Max(double[] numbers)
        {
            double result = 0.0;
            foreach (double number in numbers)
            {
                if (number > result)
                {
                    result = number;
                }
            }
            return result;
        }
        public double Min(double[] numbers)
        {
            double result = 999.9;
            foreach (double number in numbers)
            {
                if (number < result)
                {
                    result = number;
                }
            }
            return result;
        }
        public double factorial(int number)
        {
            
            double result = 1.0;
            for (int i = number; i >= 1; i--)
            {
                result *= i;
            }
            return result;
        }
        public double Multiply(double[] numbers)
        {
            double result = 1.0;
            foreach (double number in numbers)
            {
                result *= number;
            }
            return result;
        }

    } 

}
