using _03_Badges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_BadgesUI
{
    class ProgramUI
    {
        private BadgesRepo _badgesRepo = new BadgesRepo();

        public void Run()
        {
            SeedInputList();

            DisplayMenu();
        }

        private void DisplayMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();

                Console.WriteLine(
                    "Hello Security Admin, What would you like to do? \n" +
                    "1. Add a badge \n" +
                    "2. Edit a badge \n" +
                    "3. List all badges \n" +
                    "4. Exit \n");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        CreateNewBadge();

                        break;
                    case "2":
                        UpdateBadgeAccess();

                        break;
                    case "3":
                        ListAllBadges();

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

        private void CreateNewBadge()
        {
            Console.Clear();
            Badges newBadge = new Badges();
            Console.Write("What is the number on the badge: ");
            newBadge.BadgeID = int.Parse(Console.ReadLine());

            Console.Write("List a door that it needs access to:");
            string DoorName = Console.ReadLine();
            List<string> DoorNames = new List<string>();
            DoorNames.Add(DoorName);

            bool DoorAccess = true;
            while (DoorAccess)
            {
            Console.Write("Any other doors(y/n)?");
            var input = Console.ReadLine();
                if (input == "y")
                {
                    Console.WriteLine("List a door that it needs access to:");
                    string NewDoor = Console.ReadLine();
                    DoorNames.Add(NewDoor);
                }

                if (input == "n")
                {
                    DoorAccess = false;
                }
                
            }
            
            _badgesRepo.CreateNewBadge(newBadge.BadgeID, DoorNames);
        }


        private void ListAllBadges()
        {
            Console.Clear();

            Dictionary<int, List<string>> BadgeDetails = _badgesRepo.GetBadgeDetails();

            foreach (KeyValuePair<int, List<string>> details in BadgeDetails)
            {
                Console.WriteLine(details.Key);
                DisplayDetails(details.Value);
            }

            ReduceRed();
        }

        private void UpdateBadgeAccess()
        {
            Console.Clear();
         
            Console.WriteLine("What is the badge number to update?");
            int userInput = int.Parse(Console.ReadLine());
            List<string> DoorNames =_badgesRepo.FindBadgeByBadgeID(userInput);

            Console.WriteLine("What would you like to do?\n" +
                "1.Remove a door\n" +
                "2.Add a door");
            var input = Console.ReadLine();
            if (input == "1")
            {
                Console.Write("Which door would you like to remove?");
                DoorNames.Remove(Console.ReadLine());
                Console.WriteLine("Door removed.");
            }
            if (input == "2")
            {
                Console.Write("Which door would you like to add?");
                DoorNames.Add(Console.ReadLine());
                Console.WriteLine("Door added.");
            }

            _badgesRepo.UpdateExistingBadge(userInput, DoorNames);
 
            ReduceRed();
        }


        //Helper Methods

        private void DisplayDetails(List<string> input)
        {
            foreach(string doorName in input)
            {
                Console.WriteLine(doorName);
            }
                
        }

        private void ReduceRed()
        {
            Console.ReadKey();
        }

        //Seed Method


        private void SeedInputList()
        {
            Badges badge1 = new Badges(216, new List<string>() {"A1", "A2", "A3"});
            Badges badge2 = new Badges(217, new List<string>() {"B4", "B5", "B6"});
            Badges badge3 = new Badges(218, new List<string>() {"C7", "C8", "C9"});

            _badgesRepo.CreateNewBadge(badge1.BadgeID,badge1.DoorNames);
            _badgesRepo.CreateNewBadge(badge2.BadgeID,badge2.DoorNames);
            _badgesRepo.CreateNewBadge(badge3.BadgeID,badge3.DoorNames);
            
        }
    }
}
