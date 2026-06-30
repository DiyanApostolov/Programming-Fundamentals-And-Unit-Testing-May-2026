using NUnit.Framework;
using System;
using System.Collections.Generic;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestApp.Tests;

public class EvenNumbersTests
{
    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsErrorMessage_WhenStartIsGreaterThanEnd()
    {
        // Arrange
        int start = 8;
        int end = 3;
        string expectedMessage = "Start number should be smaller than end number.";

        // Act
        string result = EvenNumbers.GetEvenNumbersInRange(start, end);

        // Assert
        Assert.That(result, Is.EqualTo(expectedMessage));
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsErrorMessage_WhenStartIsNegative()
    {
        // Arrange
        int start = -8;
        int end = 3;
        string expectedMessage = "Start number should be positive number.";

        // Act
        string result = EvenNumbers.GetEvenNumbersInRange(start, end);

        // Assert
        Assert.That(result, Is.EqualTo(expectedMessage));
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsEmptyResult_WhenStartAndEndAreEqualOddNumbers()
    {
        // Arrange
        int start = 7;
        int end = 7;
        string expectedMessage = "Empty result";

        // Act
        string result = EvenNumbers.GetEvenNumbersInRange(start, end);

        // Assert
        Assert.That(result, Is.EqualTo(expectedMessage));
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsSingleEvenNumber_WhenStartAndEndAreEqualEvenNumbers()
    {
        // Arrange
        int start = 10;
        int end = 10;
        string expectedMessage = "10";

        // Act
        string result = EvenNumbers.GetEvenNumbersInRange(start, end);

        // Assert
        Assert.That(result, Is.EqualTo(expectedMessage));
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsEvenNumbers_WhenRangeHasEvens()
    {
        // Arrange
        int start = 1;
        int end = 10;
        string expectedMessage = "2, 4, 6, 8, 10";

        // Act
        string result = EvenNumbers.GetEvenNumbersInRange(start, end);

        // Assert
        Assert.That(result, Is.EqualTo(expectedMessage));
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsEvenNumbers_WhenStartAndEndAreEvenNumbers()
    {
        // Arrange
        int start = 10;
        int end = 20;
        string expectedMessage = "10, 12, 14, 16, 18, 20";

        // Act
        string result = EvenNumbers.GetEvenNumbersInRange(start, end);

        // Assert
        Assert.That(result, Is.EqualTo(expectedMessage));
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsEvenNumbers_WhenStartAndEndAreOddNumbers()
    {
        // Arrange
        int start = 3;
        int end = 9;
        string expectedMessage = "4, 6, 8";

        // Act
        string result = EvenNumbers.GetEvenNumbersInRange(start, end);

        // Assert
        Assert.That(result, Is.EqualTo(expectedMessage));
    }
}
