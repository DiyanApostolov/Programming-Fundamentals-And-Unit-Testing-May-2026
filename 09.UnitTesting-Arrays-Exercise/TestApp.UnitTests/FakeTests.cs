using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        // Arrange
        char[] inputArray = new char[] { 'A', '7', 'd', '3', 'H', '4', '#' };
        char[] expected = new char[] { 'A', 'd', 'H', '#' };

        // Act
        char[] result = Fake.RemoveStringNumbers(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        // Arrange
        char[] inputArray = new char[] { 'A', 't', 'd', 'H'};

        // Act
        char[] result = Fake.RemoveStringNumbers(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(inputArray));
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        char[] inputArray = Array.Empty<char>();

        // Act
        char[] result = Fake.RemoveStringNumbers(inputArray);

        // Assert
        Assert.That(result, Is.Empty);
    }
}
