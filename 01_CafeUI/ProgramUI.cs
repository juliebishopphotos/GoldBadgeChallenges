using _01_Cafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CafeUI
{
    public class ProgramUI
    {
        private MenuRepo _menuRepo = new MenuRepo(); 

        public void Run()
        {
            SeedMenuList();

            DisplayMenu();
        }

        private void DisplayMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();

                Console.WriteLine(
                    "Enter the number of the option you would like to select: \n" +
                    "1. Show list of menu items \n" +
                    "2. Add new menu item\n" +
                    "3. Remove menu item\n" +
                    "4. Exit \n");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        ShowListOfMenuItems();

                        break;
                    case "2":
                        CreateMenuItem();

                        break;
                    case "3":
                        DeleteMenuItem();

                        break;
                    case "4":

                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number between 1 and 4");
                        ReduceRed();
                        break;

                }
            }
        }

        private void CreateMenuItem()
        {
            Console.Clear();

            Console.Write("Please enter the meal name: ");
            string mealName = Console.ReadLine();

            Console.Write("Please enter the meal number: ");
            int mealNumber = int.Parse(Console.ReadLine());

            Console.Write("Please enter the meal discription: ");
            string mealDescription = Console.ReadLine();

            Console.Write("Please enter the list of ingredients: ");
            string listOfIngredients = Console.ReadLine();

            Console.Write("Please enter the meal price: ");
            decimal mealPrice = decimal.Parse(Console.ReadLine());

            Console.Write("Please enter new menu items: ");
            List<Menu> MenuItems = new List<Menu>();

            _menuRepo.AddItemsToMenu(new Menu(mealName, mealNumber, mealDescription, listOfIngredients, mealPrice, MenuItems));
        }


        private void ShowListOfMenuItems() 
        {
            Console.Clear();

            List<Menu> MenuItems = _menuRepo.GetItem();

            foreach (Menu items in MenuItems)
            {
                DisplayMenu(items);
            }

            ReduceRed();
        }


        private void DeleteMenuItem()
        {
            Console.Clear();

            Console.WriteLine("Which menu item would you like to remove?");

            int count = 0;

            List<Menu> menuItems = _menuRepo.GetItem();
            foreach (Menu item in menuItems)
            {
                count++;
                Console.WriteLine($"{count}. {item.MealName}");
            }

            int userInput = int.Parse(Console.ReadLine());
            int targetIndex = userInput - 1;

            if (targetIndex >= 0 && targetIndex < menuItems.Count())
            {
                Menu targetItem = menuItems[targetIndex]; 

                if (_menuRepo.DeleteMenuItem(targetItem))
                {
                    Console.WriteLine($"{targetItem.MealName} was removed from the menu");
                }
                else
                {
                    Console.WriteLine("Sorry something went wrong");
                }
            }

            else
            {
                Console.WriteLine("Invalid selection");
            }
            ReduceRed();
        }


        //Helper Methods

        private void DisplayMenu(Menu items)
        {
            Console.WriteLine($"MealName: {items.MealName}\n" +
                    $"MealNumber: {items.MealNumber}\n" +
                    $"Description: {items.Description}\n" +
                    $"ListOfIngredients: {items.ListOfIngredients}\n" +
                    $"Price: {items.Price}\n");
        }


        private void ReduceRed()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        //Seed Method

        private void SeedMenuList() 
        {
            Menu bbqPlate = new Menu("BBQ Plate", 1, "BBQ ribs served with coleslaw and mashed potatoes and gravy.", "BBQ ribs, potatoes, coleslaw and golden gravy", 10.99m, new List<Menu>());
            Menu fishAndChips = new Menu("Fish & Chips", 2, "Three pieces of breaded fish served with fries and coleslaw.", "Fish, french fries, and coleslaw", 12.99m, new List<Menu>());
            Menu friedChickenDinner = new Menu("Fried Chicken Dinner", 3, "Fried chicken served with mashed potatoes and green beans.", "Chicken, mashed potatoes, and green beans", 12.99m, new List<Menu>());

            _menuRepo.AddItemsToMenu(bbqPlate);
            _menuRepo.AddItemsToMenu(fishAndChips);
            _menuRepo.AddItemsToMenu(friedChickenDinner);
        }
    }
}
