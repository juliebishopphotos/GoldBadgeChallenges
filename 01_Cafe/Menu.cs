using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Cafe
{
    public class Menu
    {
        public string MealName { get; set; }
        public int MealNumber { get; set; }
        public string Description { get; set; }
        public string ListOfIngredients { get; set; }
        public decimal Price { get; set; } 

        public Menu() { }

        public Menu (string mealName, int mealNumber, string description, string listOfIngredients, decimal price)  
        {
            MealNumber = mealNumber;
            MealName = mealName;
            Description = description;
            ListOfIngredients = listOfIngredients;
            Price = price;
            
        }

    }
}
