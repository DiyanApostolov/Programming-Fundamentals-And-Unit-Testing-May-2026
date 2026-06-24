using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverserTests
{
    [Test]
    public void Test_ReverseStrings_WithEmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        string[] inputArray = Array.Empty<string>();

        // Act
        string[] result = Reverser.ReverseStrings(inputArray);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_ReverseStrings_WithSingleString_ReturnsReversedString()
    {
        // Arrange
        string[] inputArray = new string[] { "Hello" };
        string[] expected =  new string[] { "olleH" };

        // Act
        string[] result = Reverser.ReverseStrings(inputArray);

        // Assert - New Syntax
        Assert.That(result, Is.EqualTo(expected));

        // Assert - Old Syntax
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ReverseStrings_WithMultipleStrings_ReturnsReversedStrings()
    {
        // Arrange
        string[] inputArray = new string[] { "Hello", "Dido", "Honda", "Hi" };
        string[] expected = new string[] { "olleH", "odiD", "adnoH", "iH" };

        // Act
        string[] result = Reverser.ReverseStrings(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseStrings_WithSpecialCharacters_ReturnsReversedSpecialCharacters()
    {
        // Arrange
        string[] inputArray = new string[] { "#ello", "D1do", "$Honda", "Hi!" };
        string[] expected = new string[] { "olle#", "od1D", "adnoH$", "!iH" };

        // Act
        string[] result = Reverser.ReverseStrings(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }


    // BONUS TEST - NOT FOR JUDGE
    [Test]
    public void Test_ReverseStrings_WithSingleCharacters_ReturnsSameArray()
    {
        // Arrange
        string[] inputArray = new string[] { "A", "8", "D", "i" };

        // Act
        string[] result = Reverser.ReverseStrings(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(inputArray));
    }
}
