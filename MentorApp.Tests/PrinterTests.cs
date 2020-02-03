using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MentorApp.Tests
{
    [TestFixture]
    class PrinterTests
    {
        private StringWriter stringWriter;

        [SetUp]
        public void SetUpData()
        {
            this.stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
        }

        [Test]
        public void PrintSuccessTest()
        {
            // Arrange
            string expected = "Success!";

            // Act
            Printer.PrintSuccess("Success!");
            string result = stringWriter.GetStringBuilder()
                .ToString().Trim();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void PrintErrorTest()
        {
            // Arrange
            string expected = "Error!";

            // Act
            Printer.PrintError("Error!");
            string result = stringWriter.GetStringBuilder()
                .ToString().Trim();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void PrintInfoTest()
        {
            // Arrange
            string expected = "Info!";

            // Act
            Printer.PrintSuccess("Info!");
            string result = stringWriter.GetStringBuilder()
                .ToString().Trim();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
