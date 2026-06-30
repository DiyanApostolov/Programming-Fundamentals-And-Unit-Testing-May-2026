using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> words = new List<string> { "radar", "dad", "mom", "racecar" };

        // Act
        bool result = Palindrome.IsPalindrome(words);

        // Assert - OLD SYNTAX
        Assert.IsTrue(result);

        // Assert - NEW SYNTAX
        Assert.That(result, Is.True);
    }

    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> words = new();

        // Act
        bool result = Palindrome.IsPalindrome(words);

        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        // Arrange
        List<string> words = new List<string> { "racecar" };

        // Act
        bool result = Palindrome.IsPalindrome(words);

        // Assert 
        Assert.That(result, Is.True);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // Arrange
        List<string> words = new List<string> { "dad", "civic", "hi", "mom" };

        // Act
        bool result = Palindrome.IsPalindrome(words);

        // Assert 
        Assert.That(result, Is.False);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> words = new List<string> { "Radar", "dAD", "MOM", "RaCecAr" };

        // Act
        bool result = Palindrome.IsPalindrome(words);

        // Assert - NEW SYNTAX
        Assert.That(result, Is.True);
    }

    // BONUS TEST - NOT FOR JUDGE
    [Test]
    public void Test_IsPalindrome_SingleCharacterWords_ReturnsTrue()
    {
        // Arrange
        List<string> words = new List<string> { "d", "a", "M", "x" };

        // Act
        bool result = Palindrome.IsPalindrome(words);

        // Assert - NEW SYNTAX
        Assert.That(result, Is.True);
    }
}
