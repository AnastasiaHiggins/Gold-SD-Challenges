using System;
using System.Collections.Generic;
using System.Text;

namespace Barbecue_ClassLibrary
{
    public class IceCreamBooth
    {
        public double IceCream { get; set; }
        public double ICMisc { get; set; }
        public int ICTickets { get; set; }


        public IceCreamBooth() { }

        public IceCreamBooth(double iceCream, double icMisc, int icTickets)
        {
            IceCream = iceCream;
            ICMisc = icMisc;
            ICTickets = icTickets;
        }
    }
}