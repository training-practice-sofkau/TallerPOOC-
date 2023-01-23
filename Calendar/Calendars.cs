using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    internal class Calendars
    {
        private string _descriptionCalendar;
        private Day[] _days = new Day[30];

        public Calendars(string descriptionCalendar, Day[] days)
        {
            _descriptionCalendar = descriptionCalendar;
            Days = days;
        }

        public string DescriptionCalendar { get => _descriptionCalendar; set => _descriptionCalendar = value; }
        internal Day[] Days { get => _days; set => _days = value; }

        public override string ToString()
        {
            return _descriptionCalendar +"\n"+ _days[0].NumberDay + "\n" + _days[1].NumberDay;
        }
    }
}
