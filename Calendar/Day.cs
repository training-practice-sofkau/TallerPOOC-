using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    internal class Day
    {
        private List<Event> events;
        private String name;

        public Day()
        {
        }

        public string Name { get => name; set => name = value; }
        internal List<Event> Events { get => events; set => events = value; }
    }
}
