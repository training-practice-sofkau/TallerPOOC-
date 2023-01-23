using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    internal class Calendar
    {
        private string _descriptionCalendar;
        private Day[] _days = new Day[30];

        public Calendar(string descriptionCalendar, Day[] days)
        {
            _descriptionCalendar = descriptionCalendar;
            Days = days;
        }

        public string DescriptionCalendar { get => _descriptionCalendar; set => _descriptionCalendar = value; }
        internal Day[] Days { get => _days; set => _days = value; }
    }
}
