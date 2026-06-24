using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class RepeatingChecker_FirstReapeatingElementTests
{
    [Test]
    public void Test_FindFirstRepeatingElement_EmptyArray_ReturnsNegativeOne()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();
        int expected = -1;

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithOneInteger_ReturnsNegativeOne()
    {
        // Arrange
        int[] numbers = { 42 };
        int expected = -1;

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithManyNonRepeatingValues_ReturnsNegativeOne()
    {
        // Arrange
        int[] numbers = { 42, 7, 13, -5, 0, 2 };
        int expected = -1;

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithTwoReapeatingNegativeOneValue_ReturnsNegativeOne()
    {
        // Arrange
        int[] numbers = { -1, -1 };
        int expected = -1;

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithManyIntegerWithSameValues_ReturnsTheIntegerValue()
    {
        // Arrange
        int[] numbers = { 7, 7, 7, 7, 7, 7, 7, 7 };
        int expected = 7;

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithAtLeastTwoReaptingValues_ReturnsTheRepeatingValue()
    {
        // Arrange
        int[] numbers = { 7, 17, 3, 7, 5, 13, 27, 9 };
        int expected = 7;

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // BONUS TEST - NOT FOR JUDGE
    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithAtLeastTwoReaptingCouples_ReturnsTheFirstRepeatingValue()
    {
        // Arrange
        int[] numbers = { 7, 17, 3, 17, 5, 3, 7, 9 };
        int expected = 17;

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
