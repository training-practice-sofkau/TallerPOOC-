using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Calendar calendar = new Calendar();

            Event event1 = new Event("Event1", new DateTime(2015, 1, 1), new DateTime(2015, 1, 1));
            Event event2 = new Event("Event2", new DateTime(2015, 1, 3), new DateTime(2015, 1, 3));
            Event event3 = new Event("Event3", new DateTime(2015, 1, 2), new DateTime(2015, 1, 2));
            Event event4 = new Event("Event4", new DateTime(2015, 1, 5), new DateTime(2015, 1, 5));
            Event event5 = new Event("Event5", new DateTime(2015, 1, 4), new DateTime(2015, 1, 4));

            calendar.AddEvent(event1);
            calendar.AddEvent(event2);
            calendar.AddEvent(event3);
            calendar.AddEvent(event4);
            calendar.AddEvent(event5);

            Console.WriteLine("Events: ");
            calendar.PrintEvents();

            Console.WriteLine();
            Console.WriteLine("Sorted events: ");
            calendar.SortEvents();

            Console.ReadKey();
        }
    }
}
