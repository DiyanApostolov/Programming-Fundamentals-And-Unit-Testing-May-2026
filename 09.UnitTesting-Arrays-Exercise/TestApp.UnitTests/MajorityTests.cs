using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class MajorityTests
{
    [Test]
    public void Test_IsEvenOrOddMajority_EmpryArray_ReturnsZero()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act
        int result = Majority.IsEvenOrOddMajority(numbers);

        // Assert
        Assert.That(result, Is.Zero);
    }

    [Test]
    public void Test_IsEvenOrOddMajority_ArrayOnlyWithZeros_ReturnsZero()
    {
        // Arrange
        int[] numbers = { 0, 0, 0, 0, 0, 0 };

        // Act
        int result = Majority.IsEvenOrOddMajority(numbers);

        // Assert
        Assert.That(result, Is.Zero);
    }

    [Test]
    public void Test_IsEvenOrOddMajority_EqualOddAndEvenNumbers_ReturnsZero()
    {
        // Arrange
        int[] numbers = { 4, 6, 12, 3, 7, 11 };

        // Act
        int result = Majority.IsEvenOrOddMajority(numbers);

        // Assert
        Assert.That(result, Is.Zero);
    }

    [Test]
    public void Test_IsEvenOrOddMajority_EvenMajority_ReturnsPositiveNumber()
    {
        // Arrange
        int[] numbers = { 4, 6, 12, 8, 4, 10, 7, 11 };
        int expected = 4; 

        // Act
        int result = Majority.IsEvenOrOddMajority(numbers);

        // Assert - New Syntax
        Assert.That(result, Is.GreaterThan(0));
        Assert.That(result, Is.GreaterThanOrEqualTo(1));
        Assert.That(result, Is.EqualTo(expected)); // проверяваме разликата между множествата (не е по условие)

        // Assert - Old Syntax
        Assert.Greater(result, 0);
    }

    [Test]
    public void Test_IsEvenOrOddMajority_OddMajority_ReturnsNegativeNumber()
    {
        // Arrange
        int[] numbers = { 41, 6, 12, 8, 7, 11, 5 };

        // Act
        int result = Majority.IsEvenOrOddMajority(numbers);

        // Assert - New Syntax
        Assert.That(result, Is.LessThan(0));
        Assert.That(result, Is.LessThanOrEqualTo(-1));

        // Assert - Old Syntax
        Assert.Less(result, 0);
        Assert.LessOrEqual(result, -1);
    }
}
