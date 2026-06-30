using NUnit.Framework;
using System;
using System.Collections.Generic;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestApp.Tests;

public class NumberUtilitiesTests
{
    [Test]
    public void GetDivisibleByThree_ShouldReturnEmptyString_WhenNoNumbersDivisibleByThree()
    {
        // Arrange
        List<int> numbers = new List<int>() { 5, 8, 13, 10 };

        // Act
        string result = NumberUtilities.GetDivisibleByThree(numbers);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnEmptyString_WhenListIsEmpty()
    {
        // Arrange
        List<int> numbers = new List<int>(); // empty List

        // Act
        string result = NumberUtilities.GetDivisibleByThree(numbers);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnEmptyString_WhenListIsNull()
    {
        // Arrange
        List<int> numbers = null; // null List

        // Act
        string result = NumberUtilities.GetDivisibleByThree(numbers);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnSingleNumber_WhenOnlyOneDivisibleByThree()
    {
        // Arrange
        List<int> numbers = new List<int>() { 4, 8, 9, 10 };
        string expected = "9";

        // Act
        string result = NumberUtilities.GetDivisibleByThree(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnOnlyNumbersDivisibleByThree_WhenListHasMixedValues()
    {
        // Arrange
        List<int> numbers = new List<int>() { 12, 8, 9, 10, 21, 22, 50, 15, 2 };
        string expected = "12, 9, 21, 15";

        // Act
        string result = NumberUtilities.GetDivisibleByThree(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetDivisibleByThree_ShouldHandleNegativeNumbersCorrectly()
    {
        // Arrange
        List<int> numbers = new List<int>() { -12, 8, 9, -10, -21, 22, -50, 15, 2 };
        string expected = "-12, 9, -21, 15";

        // Act
        string result = NumberUtilities.GetDivisibleByThree(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnUniqueNumbers_WhenListHasDuplicates()
    {
        // Arrange
        List<int> numbers = new List<int>() { 12, 8, 9, 12, 9, 22, 50, 15, 2 };
        string expected = "12, 9, 15";

        // Act
        string result = NumberUtilities.GetDivisibleByThree(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

}
