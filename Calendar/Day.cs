using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    internal class Day
    {
        private int _numberDay;
        private Event[] _events = new Event[10];

        public Day(int numberDay, Event[] events)
        {
            _numberDay = numberDay;
            _events = events;
        }

        public int NumberDay { get => _numberDay; set => _numberDay = value; }
        internal Event[] Events { get => _events; set => _events = value; }
    }
}
