

using System.Collections.Generic;

namespace Calendar
{
    internal class Day
    {

        private string nameDay;
        private int dayNumber;
        private  List<Event> listEvent;

      
        public string Name {

            get { return nameDay; }
            set { nameDay = value; }
        
        }
        public int DayNumber {

            get { return dayNumber; }

            set { dayNumber  = value; }
        }

        public List<Event> ListEvent {

            get { return listEvent; }

            set { listEvent = value; }
        
        }

        public Day(int dayNumber, List<Event> listEvent, string name)
        {

            Name = name;
            DayNumber = dayNumber;
            ListEvent = listEvent;
        }

        public Day()
        {
        }
    }
}
