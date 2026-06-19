using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        // Arrange
        int input = 0;
        int expected = 0;

        // Act
        int result = Fibonacci.CalculateFibonacci(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        // Arrange
        int input = 7;
        int expected = 13;

        // Act
        int result = Fibonacci.CalculateFibonacci(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}