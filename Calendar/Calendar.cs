using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    internal class Calendar
    {
        private Day _day;

        public Calendar()
        {
            _day = new Day();
        }

        public void AddEvent(Event newEvent)
        {
            if (_day._days.ContainsKey(newEvent.StartDate))
            {
                _day._days[newEvent.StartDate].Add(newEvent);
            }
            else
            {
                _day._days.Add(newEvent.StartDate, new List<Event> { newEvent });
            }
        }

        public void RemoveEvent(Event newEvent)
        {
            if (_day._days.ContainsKey(newEvent.StartDate))
            {
                _day._days[newEvent.StartDate].Remove(newEvent);
            }
        }


        public void PrintEvents()
        {


            foreach (var day in _day._days)
            {
                Console.WriteLine(day.Key);
                foreach (var ev in day.Value)
                {
                    Console.WriteLine(ev.Name);
                }
            }
        }

        //sort events by date

        //public void SortEvents()
        //{
        //    foreach (var day in _day._days.Keys)
        //    {
        //        _day._days[day].Sort((x, y) => DateTime.Compare(x.StartDate, y.StartDate));
        //    }
        //}

        public void SortEvents()
        {
            var sorted = _day._days.Keys.ToList();
            sorted.Sort();
            foreach (var day in sorted)
            {
                Console.WriteLine(day);
                foreach (var ev in _day._days[day])
                {
                    Console.WriteLine(ev.Name);
                }
            }
        }
    }
}
