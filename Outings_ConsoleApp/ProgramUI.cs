using Outings_ClassLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Outings_ConsoleApp
{
    class ProgramUI
    {
        Outings_Repo _outings = new Outings_Repo();

        public void Run()
        {
            consoleOutings();
        }

        //syntax for printing out total costs of burgers
        //double totalCostOfBurgerExtravaganzas = _outings.CalculateBurgerCost();

        private void consoleOutings()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do?\n" +
                    "1. Create New Outing\n" +
                    "2. See All Current Outings\n" +
                    "3. Display Cost of All Outings\n");
            string userInput = Console.ReadLine();

            Console.Clear();

            switch (userInput)
            {
                case "1":
                    CreateNewOuting();
                    break;
                case "2":
                    SeeAllOutings();
                    break;
                case "3":
                    CostofOutings();
                    break;
                default:
                    Console.WriteLine("Choose an actual option, please.");
                    Console.ReadKey();
                    break;
            }
        }       


        public void SeedContent()
        {
            Outings outings1 = new Outings(27, EventType.Golf, DateTime(05 / 28 / 2019), 50.00d, 1350.00d);
            Outings outings2 = new Outings(15, EventType.Golf, DateTime(07 / 30 / 2019), 50.00d, 750.00d);
            Outings outings3 = new Outings(22, EventType.Bowling, DateTime(05 / 28 / 2019), 20.00d, 440.00d);
            Outings outings4 = new Outings(19, EventType.Bowling, DateTime(05 / 28 / 2019), 20.00d, 380.00d); 
            Outings outings5 = new Outings(34, EventType.AmusementPark, DateTime(05 / 28 / 2019), 65.00d, 2210.00d);
            Outings outings6 = new Outings(33, EventType.AmusementPark, DateTime(05 / 28 / 2019), 65.00d, 2145.00d);
            Outings outings7 = new Outings(35, EventType.Concert, DateTime(05 / 28 / 2019), 100.00d, 3500.00d);
            Outings outings8 = new Outings(35, EventType.Concert, DateTime(05 / 28 / 2019), 100.00d, 3500.00d);
            _outings.AddNewOuting(outings1);
            _outings.AddNewOuting(outings2);
            _outings.AddNewOuting(outings3);
            _outings.AddNewOuting(outings4);
            _outings.AddNewOuting(outings5);
            _outings.AddNewOuting(outings6);
            _outings.AddNewOuting(outings7);
            _outings.AddNewOuting(outings8);

        }

        
        public bool CreateNewOuting()
        {
            Console.Clear();

            Outings newEvent = new Outings();
            
            Console.WriteLine("How many attendees were there?");
            newEvent.attendeesAmount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Which event was it?\n" +
                    "1. Golf\n" +
                    "2. Bowling\n" +
                    "3. Amusement Park\n" +
                    "4. Concert");
            newEvent.Type = (EventType) Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What was the date of the event? Please enter in (mm-dd-yyyy) format");
            newEvent.Date = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("What was the cost per person?");
            newEvent.PersonCost = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("How much was the total cost?");
            newEvent.EventCost = Convert.ToDouble(Console.ReadLine());

            _outings.CreateNewOuting(newEvent);


        }

        //Read: SeeAllOutings();
        public void SeeAllOutings();
        {
            Console.Clear();

            List<Outings> eventList = _outings.GetOutings();

            foreach (Outings outing in eventList)
            {
                DisplayOutings(outing);
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

            //combined cost method
            //display by cost method
        public double CostOfOutings()
            {
                Console.Clear();
                List<Outings> eventList = _outings.SeeAllOutings();
                double totalCost = 0.0d;
                foreach (Outings outings in eventList)
                {
                    totalCost = _outings.CombinedCost();
                }
                Console.WriteLine($"Total cost of outings is {totalCost}");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                return totalCost;
            }

            public double CostsByEventType()
            {
                Console.Clear();
                List<Outings> eventList = _outings.SeeAllOutings();
                Outings event = new Outings();

                double totalCost = 0.0d;

                Console.WriteLine("Which event to see costs of?\n" +
                    "1. Golf\n" +
                    "2. Bowling\n" +
                    "3. Amusement Park\n" +
                    "4. Concert");
                int useranswer = Convert.ToInt32(Console.ReadLine());

                switch (useranswer)
                {
                    case 1:
                        totalCost = _outings.CostByEvent(EventType.AmusementPark);
                        break;
                    case 2:
                        totalCost = _outings.CostByEvent(EventType.Bowling);
                        break;
                    case 3:
                        totalCost = _outings.CostByEvent(EventType.Concert);
                        break;
                    case 4:
                        totalCost = _outings.CostByEvent(EventType.Golf);
                        break;
                }

                Console.WriteLine($"Total cost: {totalCost}");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return totalCost;
            }
        }
    }
}
