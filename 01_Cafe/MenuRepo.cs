using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Cafe
{
    public class MenuRepo
    {
        private List<Menu> _menuDirectory = new List<Menu>();

        public bool AddItemsToMenu(Menu items)
        {
            int startingCount = _menuDirectory.Count;
            _menuDirectory.Add(items);
            bool wasAdded = (_menuDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        public List<Menu> GetItem()
        {
            return _menuDirectory;
        }
        public Menu FindItemByMealNumber(int mealNumber) 
        {
            foreach (Menu item in _menuDirectory)
            {
                if (item.MealNumber == mealNumber)
                {
                    return item;
                }
            }
            return null;
        }


        public bool DeleteMenuItem(Menu existingItem)
        {
            bool deleteResult = _menuDirectory.Remove(existingItem);
            return deleteResult;
        }
    }
}
