using System;
using System.Collections.Generic;
using System.Text;

namespace Outings_ClassLibrary
{
    class Outings_Repo
    {
        //        Display a list of all outings.
        //Add individual outings to a list(don't need to worry about delete yet)
        //Calculations:
        //They'd like to see a display for the combined cost for all outings.
        //They'd like to see a display of outing costs by type.
        //For example, all bowling outings for the year were $2000.00. All Concert outings cost $5000.00.
        private List<Outings> _repo = new List<Outings>();

        public bool AddNewOuting(Outings nextEvent)
        {
            int startingEvent = _repo.Count();
            _repo.Add(nextEvent);

            bool wasAdded = (_repo.Count > startingEvent) ? true : false;
            return wasAdded;
        }




        //int startingCount = _repo.Count;
        //_repo.Add(newOuting);
        //bool wasAdded = (_repo.Count > startingCount) ? true : false;
        //return wasAdded;
        public List<Outings> SeeAllOutings()
        {
            return _repo;
        }

        public double CostOfOutings()
        {
            double chocolate = 0.0d;
            //all outings added together
            foreach (Outings happy in _repo)
            {
                //take foo
                //add EventCost to billyIdol
                chocolate += happy.EventCost;

            }
            return chocolate;
        }

        public double CostsByEventTyp(EventType type)
        {
            double total = 0.0d;
            foreach (Outings golfclubs in _repo)
            {
                if (golfclubs.Type == type)
                {
                    total += golfclubs.EventCost;
                }
            }
            return total;
        }
    }
}
