using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestApp.UnitTests;

public class ListSplitterTests
{
    [Test]
    public void Test_SplitEvenAndOdd_EmptyListParameter_ReturnsEmptyEvenAndOddLists()
    {
        // Arrange
        List<int> numbers = new List<int>();

        // Act
        (List<int>, List<int>) result = ListSplitter.SplitEvenAndOdd(numbers);

        // Assert
        Assert.That(result.Item1, Is.Empty);
        Assert.That(result.Item2, Is.Empty);
    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyEvenValues_ReturnsEmptyOddList()
    {
        // Arrange
        List<int> numbers = new List<int>() { 2, 4, 6 };

        // Act
        (List<int>, List<int>) result = ListSplitter.SplitEvenAndOdd(numbers);

        // Assert
        Assert.That(result.Item1, Is.EqualTo(numbers)); // even list
        Assert.That(result.Item2, Is.Empty); // odd list
    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyOddValues_ReturnsEmptyEvenList()
    {
        // Arrange
        List<int> numbers = new List<int>() { 1, 3, 5 };

        // Act
        (List<int>, List<int>) result = ListSplitter.SplitEvenAndOdd(numbers);

        // Assert
        Assert.That(result.Item1, Is.Empty); // even list
        Assert.That(result.Item2, Is.EqualTo(numbers)); // odd list
    }

    [Test]
    public void Test_SplitEvenAndOdd_EvenAndOddValues_ReturnsListWithCorrectValues()
    {
        // Arrange
        List<int> numbers = new List<int>() { 42, 3, 7, 10, 1, 22, 5 };

        (List<int>, List<int>) expected = (new() { 42, 10, 22 }, new() { 3, 7, 1, 5 });

        // Act
        (List<int>, List<int>) result = ListSplitter.SplitEvenAndOdd(numbers);

        // Assert
        Assert.That(result.Item1, Is.EqualTo(expected.Item1));
        Assert.That(result.Item2, Is.EqualTo(expected.Item2));
    }
}
