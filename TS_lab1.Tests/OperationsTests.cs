using TS_lab1.Core;
using System;
using Xunit;

namespace TS_lab1;

public class OperationsTests
{
    private readonly Operations _operations = new Operations();

    [Fact]
    public void TestAddItemsToList()
    {
        var list = new List<int> { 1, 2 };
        Assert.Equal(2, list.Count);
        Assert.Equal(1, list[0]);
        Assert.Equal(2, list[1]);
    }

    [Fact]
    public void TestSubtractTwoNumbers()
    {
        var result = _operations.Subtract(5, 3);
        Assert.Equal(2, result);
    }

    [Theory]
    [InlineData(4, 3, 12)]
    [InlineData(-4, 3, -12)]
    [InlineData(0, 5, 0)]
    [InlineData(7, 7, 49)]
    public void TestMultiplyTwoNumbers(int a, int b, int expected)
    {
        var result = _operations.Multiply(a, b);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(6, 3, 2)]
    [InlineData(10, 2, 5)]
    [InlineData(100, 10, 10)]
    public void TestDivideTwoNumbers(int a, int b, int expected)
    {
        var result = _operations.Divide(a, b);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestDivideByZero_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => _operations.Divide(10, 0));
    }

    [Theory]
    [InlineData(7, 3, 2)]
    [InlineData(9, 4, 2)]
    [InlineData(10, 5, 2)]
    public void TestIntegerDivision(int a, int b, int expected)
    {
        var result = _operations.IntegerDivide(a, b);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestIntegerDivisionByZero_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => _operations.IntegerDivide(10, 0));
    }

    [Theory]
    [InlineData(7, 3, 1)]
    [InlineData(10, 3, 1)]
    [InlineData(9, 4, 1)]
    public void TestFindRemainder(int a, int b, int expected)
    {
        var result = _operations.Remainder(a, b);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestRemainderByZero_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => _operations.Remainder(10, 0));
    }

    [Theory]
    [InlineData((uint)5, (uint)120)]
    [InlineData((uint)0, (uint)1)]
    [InlineData((uint)1, (uint)1)]
    [InlineData((uint)3, (uint)6)]
    public void Factorial_ShouldReturnCorrectValues(uint n, uint expected)
    {
        var result = _operations.Factorial(n);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(-5, 5)]
    [InlineData(5, 5)]
    [InlineData(0, 0)]
    public void Abs_ShouldReturnCorrectValues(int input, int expected)
    {
        var result = _operations.Abs(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new[] { 1, 3, 2 }, 3)]
    [InlineData(new[] { -1, -3, -2 }, -1)]
    [InlineData(new[] { 100, 200, 50 }, 200)]
    public void TestFindLargestNumber(int[] numbers, int expected)
    {
        var result = _operations.FindLargestNumber(numbers.ToList());
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestFindLargestNumber_EmptyList_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => _operations.FindLargestNumber(new List<int>()));
    }

    [Fact]
    public void TestCombineStrings()
    {
        var result = _operations.CombineStrings("Hello", "World");
        Assert.Equal("HelloWorld", result);
    }

    [Theory]
    [InlineData("HelloWorld", "World", true)]
    [InlineData("HelloWorld", "Hello", true)]
    [InlineData("HelloWorld", "XYZ", false)]
    public void TestSearchSubstring(string input, string searchTerm, bool expected)
    {
        var result = _operations.SearchSubstring(input, searchTerm);
        Assert.Equal(expected, result);
    }
}
