using _01_Cafe;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_CafeTest
{
    [TestClass]
    public class CafeTest
    {
        [TestMethod]
        public void SetMealName_ShouldSetCorrectString()
        {
            Menu newItem = new Menu();
            newItem.MealName = "Vegan Plate";
            string expected = "Vegan Plate";
            string actual = newItem.MealName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetMealNumber_ShouldSetCorrectInt()
        {
            Menu newItem = new Menu();
            newItem.MealNumber = 4;
            int expected = 4;
            int actual = newItem.MealNumber;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetDescription_ShouldSetCorrectString()
        {
            Menu newItem = new Menu();
            newItem.Description = "Vegan seitan steak, grilled asparagus and roasted potatoes.";
            string expected = "Vegan seitan steak, grilled asparagus and roasted potatoes.";
            string actual = newItem.Description;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetListOfIngredients_ShouldSetCorrectString()
        {
            Menu newItem = new Menu();
            newItem.ListOfIngredients = "Housemade seiten, aparagus, herbed butter, and red potatoes";
            string expected = "Housemade seiten, aparagus, herbed butter, and red potatoes";
            string actual = newItem.ListOfIngredients;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetPrice_ShouldSetCorrectDecimal()
        {
            Menu newItem = new Menu();
            newItem.Price = 10.99m;
            decimal expected = 10.99m;
            decimal actual = newItem.Price;

            Assert.AreEqual(expected, actual);
        }
    }
}
