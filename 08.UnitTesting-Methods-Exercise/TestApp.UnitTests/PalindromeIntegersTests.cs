using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PalindromeIntegersTests
{
    private PalindromeIntegers palInt;

    [SetUp]
    public void SetUp()
    {
        // вдигам нова инстанция на класа PalindromeIntegers
        palInt = new PalindromeIntegers();
    }

    [Test]
    public void Test_FindPalindromes_EmptyList_ReturnsEmptyList()
    {
        // Arrange
        List<int> input = new List<int>();

        // през инстанцията си викам нестатичните методи
        List<int> result = palInt.FindPalindromes(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindPalindromes_NoPalindromes_ReturnsEmptyList()
    {
        // Arrange
        List<int> input = new List<int>() { 123, 233, 624, 1000 };

        // Act
        List<int> result = palInt.FindPalindromes(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindPalindromes_OnlySingleDigitsElements_ReturnsSameIntegersList()
    {
        // Arrange
        List<int> input = new List<int>() { 7, 3, 9, 0 };

        // Act
        List<int> result = palInt.FindPalindromes(input);

        // Assert
        Assert.That(result, Is.EqualTo(input));
    }

    [Test]
    public void Test_FindPalindromes_AllElementsArePalindromes_ReturnsSameIntegersList()
    {
        // Arrange
        List<int> input = new List<int>() { 101, 222, 5005, 1221 };

        // Act
        List<int> result = palInt.FindPalindromes(input);

        // Assert
        Assert.That(result, Is.EqualTo(input));
    }

    [Test]
    public void Test_FindPalindromes_PalimdromesAndNoPalindromesIntegers_ReturnsOnlyPalindromes()
    {
        // Arrange
        List<int> input = new List<int>() { 101, 2225, 5505, 1221, 7, 108 };
        List<int> expected = new List<int>() { 101, 1221, 7 };

        // Act
        List<int> result = palInt.FindPalindromes(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
