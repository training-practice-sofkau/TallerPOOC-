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
            Event event2 = new Event("Event2", new DateTime(2015, 1, 1), new DateTime(2015, 1, 1));
            Event event3 = new Event("Event3", new DateTime(2015, 1, 2), new DateTime(2015, 1, 2));

            calendar.AddEvent(event1);
            calendar.AddEvent(event2);
            calendar.AddEvent(event3);

            Console.WriteLine("Events: ");
            calendar.PrintEvents();

            calendar.RemoveEvent(event2);

            Console.WriteLine("Events: ");
            calendar.PrintEvents();

            Console.ReadKey();
        }
    }
}
