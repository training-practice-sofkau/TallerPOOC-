using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    internal class Day
    {

        public Dictionary<DateTime, List<Event>> _days;

        public Day()
        {
            _days = new Dictionary<DateTime, List<Event>>();
        }


    }
}
