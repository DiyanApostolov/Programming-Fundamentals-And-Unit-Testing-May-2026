using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        // Arrange
        int[] numbers = { 12, 2, 1, 3, 4, 10, 3, 12, 15, 1 };
        int[] expected = { 1, 15, 2, 12, 3, 10, 4 }; // zig-zag sorted

        // Act
        int[] result = Pattern.SortInPattern(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act
        int[] result = Pattern.SortInPattern(numbers);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[] numbers = { 42 };

        // Act
        int[] result = Pattern.SortInPattern(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(numbers));
    }

    // BONUS TEST - NO FOR JUDGE
    [Test]
    public void Test_SortInPattern_SameElementArray_ReturnsSingleElementArray()
    {
        // Arrange
        int[] numbers = { 42, 42, 42, 42, 42, 42, 42 };
        int[] expected = { 42 };

        // Act
        int[] result = Pattern.SortInPattern(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
