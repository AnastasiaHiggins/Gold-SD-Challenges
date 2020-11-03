using Cafe_ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace Cafe_ConsoleApp
{
    class ProgramUI
    {
        private Menu_Repo _repo = new Menu_Repo();
        private List<Menu> _menu = new List<Menu>();

        string userInput = Console.ReadLine();

        public void Run()
        {
            MenuContent();
            consoleMenu();
        }

        private void MenuContent()
        {
            Menu potatoSoup = new Menu(
                1,
                "Potato Bacon Cheddar Soup",
                "Cheesy potatoes and bacon make soupy goodness",
                "Potatoes, Cheese, Bacon, Soup",
                5.99m
            );

            _repo.CreateNewMenuItem(potatoSoup);
        }

        private void consoleMenu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine(
                    "What would you like to do?\n" +
                    "1. Create New Menu Item\n" +
                    "2. See Entire Menu\n" +
                    "3. Delete Menu Item\n" +
                    "4. Update Existing Menu Item");

                string userInput = Console.ReadLine();

                Console.Clear();

                switch (userInput)
                {
                    case "1":
                        CreateNewMenuItem();
                        break;
                    case "2":
                        ShowEntireMenu();
                        break;
                    case "3":
                        DeleteMenuItem();
                        break;
                    //case "4":
                    //    UpdateExistingContent();
                    //    break;
                    case "5":
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Choose an actual option, please.");
                        Console.ReadKey();
                        break;
                }
            }
        }


        //create
        void CreateNewMenuItem()
        {
            Console.Clear();

            Menu newDish = new Menu();

            Console.WriteLine();
            string NumberAsString = Console.ReadLine();
            int NumberAsDecimal = int.Parse(NumberAsString);

            Console.WriteLine("What is the name of your new menu item?");
            newDish.Name = Console.ReadLine();

            newDish.Descriptor = Console.ReadLine();
            newDish.Ingredients = Console.ReadLine();

            Console.WriteLine();
            string PriceAsString = Console.ReadLine();
            decimal PriceAsDecimal = decimal.Parse(PriceAsString);
        }

        void ShowEntireMenu()
        {
            Console.Clear();

            List<Menu> menuList = _repo.GetMenu();

            foreach (Menu content in menuList)
            {
                DisplayContent(content);
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }


        //delete
        void DeleteMenuItem()
        {
            ShowEntireMenu();
            Console.WriteLine("Which menu item would you like to delete?");

            string itemToDelete = Console.ReadLine();

            Menu contentToDelete = _repo.GetMenuByName(itemToDelete);
            bool wasDeleted = _repo.DeleteMenuItem(contentToDelete);

            if (wasDeleted)
            {
                Console.WriteLine("Menu item was successfully removed!");
            }
            else
            {
                Console.WriteLine("Could not delete. Sorry :(");
            }
        }
    }
}        //            private void ShowFullMenu()
         //            {
         //                Console.Clear();
         //                List<KMenu> listofContent = _menuRepo.GetFullMenu();
         //                foreach (KMenu menuItem in listofContent)
         //                {
         //                    Console.WriteLine(menuItem.MealLetter);
         //                    Console.WriteLine(menuItem.MealName);
         //                    Console.WriteLine(menuItem.MealDescription);
         //                    Console.WriteLine(menuItem.MealIngredients);
         //                    Console.WriteLine(menuItem.MealPrice);
         //                }
         //​
         //            Console.WriteLine("Press any key to continue");
         //                Console.ReadKey();
         //​
         //        }
         //​
         //        private void CreateNewMenuItem()
         //        {
         //            Console.Clear();
         //​
         //            KMenu newMenuItem = new KMenu();
         //​
         //            Console.WriteLine("Please enter a Meal Letter.");
         //            newMenuItem.MealLetter = Console.ReadLine();
         //​
         //            Console.WriteLine("Please enter a Meal Name.");
         //            newMenuItem.MealName = Console.ReadLine();
         //​
         //            Console.WriteLine("Please enter a Meal Description.");
         //            newMenuItem.MealDescription = Console.ReadLine();
         //​
         //            Console.WriteLine("Please enter Meal Ingredients.");
         //            newMenuItem.MealIngredients = Console.ReadLine();
         //​
         //            Console.WriteLine("Please enter a Meal Price.");
         //            string priceAsString = Console.ReadLine();
         //            double priceAsDouble = double.Parse(priceAsString);
         //            newMenuItem.MealPrice = priceAsDouble;
         //​
         //            _menuRepo.AddMenu(newMenuItem);
         //​
         //        }
         //​
         //        private void DeleteExistingItem()
         //        {
         //            ShowFullMenu();
         //            Console.WriteLine("Enter the letter of the menu item you would like to delete.");
         //            string menuLetterToDelete = Console.ReadLine();
         //​
         //            KMenu contentToDelete = _menuRepo.GetMealByLetter(menuLetterToDelete);
         //            bool wasDeleted = _menuRepo.DeleteExistingItem(contentToDelete);
         //​
         //            if (wasDeleted)
         //            {
         //                Console.WriteLine("This content was successfully deleted.");
         //            }
         //            else
         //            {
         //                Console.WriteLine("Content could not be deleted");

//            }

