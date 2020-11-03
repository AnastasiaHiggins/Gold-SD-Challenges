using System;
using System.ComponentModel;

namespace Outings_ClassLibrary
{
    public class Outings
    {
        public int AttendeesAmount { get; set; }
        public enum eventType { Golf, Bowling, Amusement_Park, Concert }
        public DateTime Date { get; set; }
        public double PersonCost { get; set; }
        public double EventCost { get; set; }

        public Outings() { }
        public Outings(int attendeesAmount, enum eventType, DateTime date, double personCost, double eventCost);
        
            AttendeesAmount = attendeesAmount;
            EventType = eventType;
            Date = date;
            PersonCost = personCost;
            EventCost = eventCost;
         
    }
}
