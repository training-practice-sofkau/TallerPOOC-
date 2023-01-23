// See https://aka.ms/new-console-template for more information
using Calendar;

internal class Program
{
    private static void Main(string[] args)
    {
        Event daily = new Event
        {
            Name = "daily",
            StartDate = new DateTime(2023, 01, 23).AddHours(8).AddMinutes(00).AddSeconds(00),
            EndDate = new DateTime(2023, 01, 23).AddHours(8).AddMinutes(15).AddSeconds(00),
        };

        Event taller = new Event
        {
            Name = "taller",
            StartDate = new DateTime(2023, 01, 23).AddHours(11).AddMinutes(00).AddSeconds(00),
            EndDate = new DateTime(2023, 01, 23).AddHours(13).AddMinutes(00).AddSeconds(00),
        };

        Event sustentacion = new Event
        {
            Name = "sustentacion",
            StartDate = new DateTime(2023, 01, 23).AddHours(17).AddMinutes(00).AddSeconds(00),
            EndDate = new DateTime(2023, 01, 23).AddHours(18).AddMinutes(00).AddSeconds(00),
        };

        Event daily2 = new Event
        {
            Name = "daily",
            StartDate = new DateTime(2023, 01, 24).AddHours(8).AddMinutes(00).AddSeconds(00),
            EndDate = new DateTime(2023, 01, 24).AddHours(8).AddMinutes(15).AddSeconds(00),
        };

        Event taller2 = new Event
        {
            Name = "taller",
            StartDate = new DateTime(2023, 01, 24).AddHours(10).AddMinutes(00).AddSeconds(00),
            EndDate = new DateTime(2023, 01, 24).AddHours(11).AddMinutes(00).AddSeconds(00),
        };

        Event sustentacion2 = new Event
        {
            Name = "sustentacion",
            StartDate = new DateTime(2023, 01, 24).AddHours(17).AddMinutes(30).AddSeconds(00),
            EndDate = new DateTime(2023, 01, 24).AddHours(18).AddMinutes(30).AddSeconds(00),
        };

        Event daily3 = new Event
        {
            Name = "daily",
            StartDate = new DateTime(2023, 01, 25).AddHours(8).AddMinutes(00).AddSeconds(00),
            EndDate = new DateTime(2023, 01, 25).AddHours(8).AddMinutes(15).AddSeconds(00),
        };

        Event taller3 = new Event
        {
            Name = "taller",
            StartDate = new DateTime(2023, 01, 25).AddHours(10).AddMinutes(30).AddSeconds(00),
            EndDate = new DateTime(2023, 01, 25).AddHours(11).AddMinutes(00).AddSeconds(00),
        };

        Event sustentacion3 = new Event
        {
            Name = "sustentacion",
            StartDate = new DateTime(2023, 01, 25).AddHours(16).AddMinutes(00).AddSeconds(00),
            EndDate = new DateTime(2023, 01, 25).AddHours(17).AddMinutes(00).AddSeconds(00),
        };


        List<Event> events = new List<Event>
        {
             daily,taller,sustentacion,
             
        };
        List<Event> events2 = new List<Event>
        {
             daily2,taller2,sustentacion2,

        };
        List<Event> events3 = new List<Event>
        {
             daily3,taller3,sustentacion3,

        };

        Day day1 = new Day
        {
            Name = "Lunes",
            Events = events
        };

        Day day2 = new Day
        {
            Name = "martes",
            Events = events2
        };

        Day day3 = new Day
        {
            Name = "miercoles",
            Events = events3
        };

        List<Day> days = new List<Day>
        {
             day1,
             day2,
             day3,

        };

        Calendar.Calendar calendar = new Calendar.Calendar(days);
        foreach (var day in calendar.Days)
        {
            Console.WriteLine(day.Name);
            foreach (var eventos in day.Events)
            {
                Console.WriteLine(eventos.Name);
                Console.WriteLine(eventos.StartDate);
                Console.WriteLine(eventos.EndDate);
            }
        }      

    }   
    
}



