using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Barbecue_ClassLibrary
{
    public class PartyRepo
    {
        private List<BurgerBooth> _burger = new List<BurgerBooth>();
        private List<IceCreamBooth> _icecream = new List<IceCreamBooth>();



        public bool NewBurgerBooth(BurgerBooth newBurger)
        {
            int startingCount = _burger.Count;
            _burger.Add(newBurger);
            bool wasAdded = (_burger.Count > startingCount) ? true : false;
            return wasAdded;
        }
        public bool NewIceCreamBooth(IceCreamBooth newIceCream)
        {
            int startingCount = _icecream.Count;
            _icecream.Add(newIceCream);
            bool wasAdded = (_icecream.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //total cost for party
        public double CalculateBurgerCost()
        {
            double burgersum = 0.0d;
            foreach (BurgerBooth burger in _burger)
            {
                burgersum += (burger.VeggieBurgers + burger.Hamburgers + burger.HotDogs + burger.BBMisc);
            }
            return burgersum;
        }
        //goes in program UI
        //make double variable
        //_repo.calculateburgercost
        //double variable = _repo.calculateburgercost();
        //console.writeline(variable);
        //would print total burger cost


        //double combinecost = burgervariable + icecreamvariable
        public double CalculateIceCreamCost()
        {
            double icecreamsum = 0.0d;
            foreach (IceCreamBooth icecream in _icecream)
            {
                icecreamsum += (icecream.IceCream + icecream.ICMisc);
            }
            return icecreamsum;

        }



        public double CalculatePartyCost()
        {
            double partysum = 0.0d;
            partysum += (burgersum + icecreamsum);


            return partysum;


            //add burgers
            //add ice cream
            //add together


            //public int SeeBurgerTickets()
            //{
            //    return ;
            //}
        }
        public int SeeBurgerTickets()
        {
            int burgerTickets;
            foreach (BurgerBooth tickets in _burger)
            {
                return tickets.BBTickets;
            }
        }
        
        public int SeeIceCreamTickets
            int iceCreamTickets;
            foreach (IceCreamBooth tickets in _icecream)
            {
                return tickets.ICTickets;
            }

        }
        public double CalculateTickets()
        {
            double ticketsum = 0.0d;
            ticketsum += (BBTickets + ICTickets);

            return ticketsum;


            //total tickets for each booths
            //total tickets taken
        }
    }
}
