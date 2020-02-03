using NUnit.Framework;
using System.Collections.Generic;

namespace MentorApp.Tests
{
    [TestFixture]
    public class DataManipulatorTests
    {
        private DataManipulator dataManipulator { get; set; }
        public DataManipulatorTests()
        {
            this.dataManipulator = new DataManipulator();
        }

        [Test]
        public void GetStringElemsTest()
        {
            // Arrange
            string testStr = "1,2/3.4\\5";

            List<string> expectedList = new List<string>() { "1", "2", "3", "4", "5" };

            // Act
            List<string> resultList = dataManipulator.GetStringElems(testStr);

            // Assert
            Assert.AreEqual(expectedList, resultList);
        }
    }
}