using Barbecue_ClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbecue_ConsoleApp
{
    class ProgramUI
    {
        private PartyRepo _repo = new PartyRepo();
        private List<BurgerBooth> _burger = new List<BurgerBooth>();
        private List<IceCreamBooth> _icecream = new List<IceCreamBooth>();

        string userInput = Console.ReadLine();

        public void Run()
        {
            PartyContent();
            consoleParty();
        }

        public void BurgerContent()
        {
            BurgerBooth BurgerHaus = new BurgerBooth(
                50.00d,
                100.00d,
                75.00d,
                50.00d,
                50
            );
            _repo.NewBurgerBooth(BurgerHaus);
        }

        public void IceCreamContent()
        {
            IceCreamBooth WeenieHutJrs = new IceCreamBooth(
                100.00d,
                50.00d,
                75
            );
            _repo.NewIceCreamBooth(WeenieHutJrs);
        }

        private void consoleParty()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                //total cost for party
                //will need a sum method specifically for all costs

                //total tickets for each booths
                //simple read method

                //total tickets taken
                //another sum method for both booths' tickets

                Console.Clear();
                Console.WriteLine(
                    "What would you like to do?\n" +
                    "1. Calculate total cost of party\n" +
                    "2. See tickets taken by Burger Haus\n" +
                    "3. See tickets taken by Weenie Hut Jr's\n" +
                    "4. Calculate all tickets taken\n");

                string userInput = Console.ReadLine();

                Console.Clear();

                switch (userInput)
                {
                    case "1":
                        CalculatePartyCost();
                        break;
                    case "2":
                        SeeTicketsByBooth();
                        break;
                    case "2":
                        SeeTicketsByBooth();
                        break;
                    case "4":
                        CalculateTickets();
                        break;
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
    }
}
