using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    internal class Calendary
    {
        private Day daysMonth;

        public Day DaysMonth
        {
            get { return daysMonth; }
            set { daysMonth = value; }
        }

        public Calendary(Day daysMonth)
        {
            DaysMonth = daysMonth;
        }
    }
}
