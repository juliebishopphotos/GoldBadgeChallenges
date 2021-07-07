using _02_Claims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ClaimsUI
{
    public class ProgramUI
    {
        private ClaimsRepo _claimsRepo = new ClaimsRepo();

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
                    "Choose a menu item: \n" +
                    "1. See all claims \n" +
                    "2. Take care of next claim \n" +
                    "3. Enter a new claim \n" +
                    "4. Exit \n");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        ShowListOfAllClaims();

                        break;
                    case "2":
                        TakeCareOfNextClaim();

                        break;
                    case "3":
                        AddNewClaim();

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

        private void AddNewClaim()
        {
            Console.Clear();

            Console.Write("Enter the claim ID: ");
            int claimID = int.Parse(Console.ReadLine());

            Console.Write("Enter the claim type: ");
            string claimType = (Console.ReadLine());

            Console.Write("Enter a claim discription: ");
            string description = Console.ReadLine();

            Console.Write("Amount of damage: ");
            decimal claimAmount = decimal.Parse(Console.ReadLine());

            Console.Write("Date of Incident: ");
            DateTime dateOfIncident = DateTime.Parse(Console.ReadLine());

            Console.Write("Date of Claim: ");
            DateTime dateOfClaim = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Claim is valid: ");
            bool isValid = bool.Parse(Console.ReadLine());
            
            Console.Write("Show list of claim: ");
            List<Claims> ListOfClaims = new List<Claims>();


            _claimsRepo.AddNewClaim(new Claims(claimID, claimType, description, claimAmount, dateOfIncident, dateOfClaim, isValid, ListOfClaims));
        }


        private void ShowListOfAllClaims()
        {
            Console.Clear();

            Queue<Claims> ClaimInput = _claimsRepo.GetClaim();

            foreach (Claims input in ClaimInput)
            {
                DisplayInput(input);
            }

            ReduceRed();
        }


        private void TakeCareOfNextClaim() 
        {
            Console.Clear();

            Console.WriteLine("Here are the details for the next claim to be handled:");

            bool DealWithClaim = true;
            while (DealWithClaim)
            {
                Console.WriteLine("Do you want to deal with this claim now (y/n)?");
                var input = Console.ReadLine();
                if (input == "y")
                {
                    Console.WriteLine("REMOVE");
                }
                if (input == "n")
                {
                    DealWithClaim = false;
                }
                
            }

        }


        //Helper Methods

        private void DisplayInput(Claims input)
        {
            Console.WriteLine($"ClaimID: {input.ClaimID}\n" +
                    $"ClaimType: {input.ClaimType}\n" +
                    $"Description: {input.Description}\n" +
                    $"ClaimAmount: {input.ClaimAmount}\n" +
                    $"DateOfIncident: {input.DateOfIncident.ToString("MM/dd/yyyy")}\n" +
                    $"DateOfClaim: {input.DateOfClaim.ToString("MM/dd/yyyy")}\n" +
                    $"IsValid: {input.IsValid}\n");

        }


        private void ReduceRed()
        {
            Console.WriteLine("Press any key to return to main menu.");
            Console.ReadKey();
        }

        //Seed Method

        private void SeedInputList() 
        {
            Claims Car = new Claims( 1, "Car", "Car accident on 1-65.", 1000.00m, new DateTime(2020, 8, 22), new DateTime(2020, 9, 15), true, new List<Claims>());
            Claims Home = new Claims( 2, "Home", "House fire in kitchen.", 25000.00m, new DateTime(2019, 2, 15), new DateTime(2019, 02, 28), true, new List<Claims>());
            Claims Theft = new Claims( 3, "Theft", "Stolen Purse.", 200.00m, new DateTime(2019, 1, 9), new DateTime(2019, 3, 17), false, new List<Claims>());

            _claimsRepo.AddNewClaim(Car);
            _claimsRepo.AddNewClaim(Home);
            _claimsRepo.AddNewClaim(Theft);
        }
    }
}
