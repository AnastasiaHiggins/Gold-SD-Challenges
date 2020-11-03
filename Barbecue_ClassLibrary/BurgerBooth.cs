using System;
using System.ComponentModel.Design;

namespace Barbecue_ClassLibrary
{
    public class BurgerBooth
    {
        public double VeggieBurgers { get; set; }
        public double Hamburgers { get; set; }
        public double HotDogs { get; set; }
        public double BBMisc { get; set; }
        public int BBTickets { get; set; }

        public BurgerBooth() { }
        public BurgerBooth(double veggieBurgers, double hamburgers, double hotDogs, double bbMisc, int bbTickets)
        {

            VeggieBurgers = veggieBurgers;
            Hamburgers = hamburgers;
            HotDogs = hotDogs;
            BBMisc = bbMisc;
            BBTickets = bbTickets;
        }
    }
}
