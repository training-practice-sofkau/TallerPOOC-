using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    internal class Day
    {
        private List<Event> eventsDay;

        public List<Event> EventsDay
        {
            get { return eventsDay; }
            set { eventsDay = value; }
        }

        public Day(List<Event> eventsDay)
        {
            EventsDay = eventsDay;
        }
    }
}
