using System;
using System.Diagnostics;

namespace TS_lab1.Core
{
    public class Operations
    {
        public int Subtract(int a, int b) => a - b;
        public int Multiply(int a, int b) => a * b;

        public int Divide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException ex)
            {
                throw new ArgumentException("Division by zero is not allowed", nameof(b), ex);
            }
        }

        public int IntegerDivide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException ex)
            {
                throw new ArgumentException("Integer division by zero is not allowed", nameof(b), ex);
            }
        }

        public int Remainder(int a, int b)
        {
            try
            {
                return a % b;
            }
            catch (DivideByZeroException ex)
            {
                throw new ArgumentException("Remainder by zero is not allowed", nameof(b), ex);
            }
        }

        public uint Factorial(uint n) => n == 0 ? 1 : n * Factorial(n - 1);

        public int Abs(int a)
        {
            if (a == -a) return 0; 
            if (a < 0) return -a;
            return a;
        }

        public int FindLargestNumber(List<int> numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                throw new ArgumentException("The list cannot be empty", nameof(numbers));
            }
            return numbers.Max();
        }

        public string CombineStrings(string a, string b) => a + b;

        public bool SearchSubstring(string text, string substring) => text.Contains(substring);
    }
}
