using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class TopIntegersTests
{
    private TopIntegers topIntegers; // декларирам си променлива

    [SetUp]
    public void SetUp()
    {
        topIntegers = new TopIntegers(); // вдигаме нова инстанция на класа TopIntegers
    }

    [Test]
    public void Test_FindTopIntegers_EmptyArrayParameter_ReturnEmptyString()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act
        string result = topIntegers.FindTopIntegers(numbers);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindTopIntegers_AllElementsAreTopIntegers_ReturnStringWithAllElements()
    {
        // Arrange
        int[] numbers = { 42, 13, 7, 2 };
        string expeced = string.Join(' ', numbers);

        // Act
        string result = topIntegers.FindTopIntegers(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expeced));
    }

    [Test]
    public void Test_FindTopIntegers_OnlyOneElementArray_ReturnStringWithOneInteger()
    {
        // Arrange
        int[] numbers = { 42 };
        string expeced = "42";

        // Act
        string result = topIntegers.FindTopIntegers(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expeced));
    }

    [Test]
    public void Test_FindTopIntegers_OnlySomeElementsAreTopIntegers_ReturnStringWithOnlyTopIntegers()
    {
        // Arrange
        int[] numbers = { 14, 24, 3, 19, 15, 17 };
        string expeced = "24 19 17";

        // Act
        string result = topIntegers.FindTopIntegers(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expeced));
    }
}

