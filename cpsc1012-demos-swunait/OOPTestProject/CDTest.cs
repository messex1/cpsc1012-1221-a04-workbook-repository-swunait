using PracticeObjectProblem1;

namespace OOPTestProject
{
    [TestClass]
    public class CDTest
    {
        [TestMethod]
        [DataRow("Back in Black","AC/DC",10,9.95, "Back in Black   AC/DC              $9.95")]
        [DataRow("Led Zeppelin IV", "Led Zeppelin", 15, 10.95, "Led Zeppelin IV Led Zeppelin      $10.95")]
        public void CDInfo_ValidData_ReturnInfo(string title, string artist, int tracks, double price,
            string expectedCdInfo)
        {
            // Arrange
            CD currentCD = new CD(title, artist, tracks, price);
            // Act
            string actualCdInfo = currentCD.CDInfo();
            // Assert
            Assert.AreEqual(expectedCdInfo, actualCdInfo);
        }

        [TestMethod]
        [DataRow("Back in Black", "AC/DC", 0, 9.95, "Tracks must be 1 or more")]
        [DataRow("Led Zeppelin IV", "Led Zeppelin", -15, 10.95, "Tracks must be 1 or more")]
        public void Tracks_InvalidTracks_ThrowsException(
           string title, string artist, int tracks, double price,
           string expectedErrorMessage)
        {
            try
            {
                // Arrange and Act
                CD currentCD = new CD(title, artist, tracks, price);
                Assert.Fail("An exception should have been thrown");
            }
            catch(ArgumentException e)
            {
                //Assert.AreEqual(expectedErrorMessage, e.Message);
                StringAssert.Contains(e.Message, expectedErrorMessage);
            }
        }

        [TestMethod]
        [DataRow("", "AC/DC", 10, 9.95, "Title cannot be blank")]
        [DataRow("              ", "Led Zeppelin", 15, 10.95, "Title cannot be blank")]
        public void Title_InvalidTitle_ThrowsException(
           string title, string artist, int tracks, double price,
           string expectedErrorMessage)
        {
            try
            {
                // Arrange and Act
                CD currentCD = new CD(title, artist, tracks, price);
                Assert.Fail("An exception should have been thrown");
            }
            catch (ArgumentException e)
            {
                //Assert.AreEqual(expectedErrorMessage, e.Message);
                StringAssert.Contains(e.Message, expectedErrorMessage);
            }
        }


    }
}