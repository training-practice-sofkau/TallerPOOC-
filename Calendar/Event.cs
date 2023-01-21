using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    internal class Event
    {
        private string name;
        private DateTime startDate;
        private DateTime endDate;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public Event(string name, DateTime startDate, DateTime endDate)
        {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
        }

        public override string ToString()
        {
            return $"  '{Name}' inicia el: {StartDate.ToLongDateString()} y finaliza: {EndDate.ToLongDateString()}";
        }
    }
}