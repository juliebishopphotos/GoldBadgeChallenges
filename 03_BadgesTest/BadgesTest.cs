using _03_Badges;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_BadgesTest
{
    [TestClass]
    public class BadgesTest
    {

        [TestMethod]
        public void UpdateBadgeDetails_ShouldUpdateCorrectInt()
        {
            Badges newDetails = new Badges();
            newDetails.BadgeID = 210;
            int expected = 210;
            int actual = newDetails.BadgeID;

            Assert.AreEqual(expected, actual);

        }

    }
}
