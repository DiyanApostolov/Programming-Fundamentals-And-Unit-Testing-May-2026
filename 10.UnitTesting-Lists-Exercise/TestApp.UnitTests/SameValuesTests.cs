using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SameValuesTests
{
    [Test]
    public void Test_FindSameValues_EmptyFirstList_ReturnsEmptyList()
    {
        // Arrange
        List<int> firstList = new List<int>(); // empty
        List<int> secondList = new List<int>() { 5, 42, 7, 11};

        // Act
        List<int> result = SameValues.FindSameValues(firstList, secondList);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_EmptySecondList_ReturnsEmptyList()
    {
        // Arrange
        List<int> firstList = new List<int>() { 1, 2, 34 };
        List<int> secondList = new List<int>(); // empty

        // Act
        List<int> result = SameValues.FindSameValues(firstList, secondList);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_NoSameValuesInBothLists_ReturnsEmptyList()
    {
        // Arrange
        List<int> firstList = new List<int>() { 1, 2, 34 };
        List<int> secondList = new List<int>() { 5, 42, 8, 11, 5 };

        // Act
        List<int> result = SameValues.FindSameValues(firstList, secondList);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_BothListWithSameValues_ReturnsListWithSameValues()
    {
        // Arrange
        List<int> firstList = new List<int>() { 1, 2, 34, 7, 2, 5, 33};
        List<int> secondList = new List<int>() { 5, 2, 8, 11, 5 };

        List<int> expected = new() { 2, 5 };

        // Act
        List<int> result = SameValues.FindSameValues(firstList, secondList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
