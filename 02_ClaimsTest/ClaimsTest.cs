using _02_Claims;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_ClaimsTest
{
    [TestClass]
    public class ClaimsTest
    {
        [TestMethod]
            public void SetClaimID_ShouldSetCorrectInt()
            {
                Claims newInput = new Claims();
                newInput.ClaimID = 1;
                int expected = 1;
                int actual = newInput.ClaimID;

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void SetClaimType_ShouldSetCorrectString()
            {
                Claims newInput = new Claims();
                newInput.ClaimType = "Car";
                string expected = "Car";
                string actual = newInput.ClaimType;

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void SetDescription_ShouldSetCorrectString()
            {
                Claims newInput = new Claims();
                newInput.Description = "Car accident on 465.";
                string expected = "Car accident on 465.";
                string actual = newInput.Description;

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void SetClaimAmount_ShouldSetCorrectString()
            {
                Claims newInput = new Claims();
                newInput.ClaimAmount = 1500;
                decimal expected = 1500;
                decimal actual = newInput.ClaimAmount;

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void SetDateOfIncident_ShouldSetCorrectDateTime()
            {
                Claims newInput = new Claims();
                newInput.DateOfIncident = new DateTime (2021-03-14);
                DateTime expected = new DateTime (2021-03-14);
                DateTime actual = newInput.DateOfIncident;

                Assert.AreEqual(expected, actual);
            }
    }
}
