using _01_Cafe;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_CafeTest
{
    [TestClass]
    public class CafeTest
    {
        [TestMethod]
        public void SetMealNumber_ShouldSetCorrectInt()
        {
            Menu newItem = new Menu();
            newItem.MealNumber = 6;
            int expected = 6;
            int actual = newItem.MealNumber;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetMealName_ShouldSetCorrectString()
        {
            Menu newItem = new Menu();
            newItem.MealName = "Tofu Bahn Mi";
            string expected = "Tofu Bahn Mi";
            string actual = newItem.MealName;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void SetDescription_ShouldSetCorrectString()
        {
            Menu newItem = new Menu();
            newItem.Description = "Grilled tofu, pickled carrot, cucumber, cilantro, jalapenos and spicy mayo on a toasted roll.";
            string expected = "Grilled tofu, pickled carrot, cucumber, cilantro, jalapenos and spicy mayo on a toasted roll.";
            string actual = newItem.Description;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetListOfIngredients_ShouldSetCorrectString()
        {
            Menu newItem = new Menu();
            newItem.ListOfIngredients = "Organic tofu, carrots, cucumber, cilantro, jalapenos, mayo, hot sauce and local baguette";
            string expected = "Organic tofu, carrots, cucumber, cilantro, jalapenos, mayo, hot sauce and local baguette";
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

        [TestMethod]
        public void AddItemsToMenu_ShouldGetCorrectBoolean()
        {
            Menu newItems = new Menu();
            MenuRepo repository = new MenuRepo();

            bool addResult = repository.AddItemsToMenu(newItems);

            Assert.IsTrue(addResult);
        }

        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            Menu testItem = new Menu("Vegan Plate", 4, "Vegan seitan steak, grilled asparagus and roasted potatoes.", "Housemade seiten, aparagus, herbed butter, and red potatoes", 10.99m);
            MenuRepo repo = new MenuRepo();
            repo.AddItemsToMenu(testItem);
            
            List<Menu> items = repo.GetItem();
            bool directoryHasItem = items.Contains(testItem);
           
            Assert.IsTrue(directoryHasItem);
        }

    }
}
