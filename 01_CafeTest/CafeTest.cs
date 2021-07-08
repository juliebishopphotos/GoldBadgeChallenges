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
        public void AddItemsToMenu_ShouldGetCorrectBoolean()
        {
            //Arrange
            Menu newItems = new Menu();
            MenuRepo repository = new MenuRepo();
            //Act
            bool addResult = repository.AddItemsToMenu(newItems);
            //Assert
            Assert.IsTrue(addResult);
        }

        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            //Arrange
            Menu testItem = new Menu("Vegan Plate", 4, "Vegan seitan steak, grilled asparagus and roasted potatoes.", "Housemade seiten, aparagus, herbed butter, and red potatoes", 10.99m);
            MenuRepo repo = new MenuRepo();
            repo.AddItemsToMenu(testItem);
            //ACT
            List<Menu> items = repo.GetItem();
            bool directoryHasItem = items.Contains(testItem);
            //Assert
            Assert.IsTrue(directoryHasItem);
        }



        [TestMethod]
        public void DeleteMenuItem_ShouldReturnTrue()
        {
            //Arrange
            Menu foundItem = _repo.FindItemByMealNumber(3);
            //ACT
            bool removeItem = _repo.DeleteMenuItem(foundItem);
            //Assert
            Assert.IsTrue(removeItem);

        }
    }
}
