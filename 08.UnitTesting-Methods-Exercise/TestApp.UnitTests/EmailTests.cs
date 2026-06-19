using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class EmailTests
{
    // TODO: finish test
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string validEmail = "test@example.com";

        // Act
        bool result = Email.IsValidEmail(validEmail);

        // Assert - OLD SYNTAX
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        // Arrange
        string invalidEmail = "@gmail.com";

        // Act
        bool result = Email.IsValidEmail(invalidEmail);

        // Assert - OLD SYNTAX
        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        // Arrange
        string input = null;

        // Act
        bool result = Email.IsValidEmail(input);

        // Assert - NEW SYNTAX
        Assert.That(result, Is.False);
    }
}
