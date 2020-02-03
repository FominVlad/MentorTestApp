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
        public void GetMaxLineTest()
        {
            // Arrange
            List<string> testList = new List<string>()
            {
                "1, 1",
                "4, 4",
                "3, sdf",
                "2, 2"
            };

            int expectedMaxIndex = 1;
            List<int> expectedBadList = new List<int>() { 2 };

            List<int> resultBadList;

            // Act
            int resultMaxIndex = dataManipulator.GetMaxLine(testList, out resultBadList);

            // Assert
            Assert.AreEqual(expectedMaxIndex, resultMaxIndex);
            Assert.AreEqual(expectedBadList, resultBadList);
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

        [Test]
        public void GetStrSummTest()
        {
            // Arrange
            List<string> testList = new List<string>()
            {
                "1",
                "4",
                "sdf",
                "2"
            };

            int expectedSumm = 7;
            bool expectedIsBad = true;

            bool resultIsBad;

            // Act
            int resultSumm = dataManipulator.GetStrSumm(testList, out resultIsBad);

            // Assert
            Assert.AreEqual(expectedSumm, resultSumm);
            Assert.AreEqual(expectedIsBad, resultIsBad);
        }
    }
}