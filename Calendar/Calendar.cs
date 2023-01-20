using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    internal class Calendar
    {
        private List<Day> days;

        public Calendar(List<Day> days)
        {
            this.days = days;
        }

        internal List<Day> Days { get => days; set => days = value; }
    }
}
