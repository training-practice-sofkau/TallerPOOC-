using Calendar;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Event evento1 = new Event("Master class", new DateTime(2023, 01, 23, 8, 30, 00), new DateTime(2023, 01, 23, 9, 30, 00));
        Event evento2 = new Event("Workshop .Net", new DateTime(2023, 01, 23, 11, 15, 00), new DateTime(2023, 01, 23, 12, 00, 00));
        Event evento3 = new Event("Master class", new DateTime(2023, 01, 24, 8, 30, 00), new DateTime(2023, 01, 24, 9, 30, 00));
        Event evento4 = new Event("Workshop .Net", new DateTime(2023, 01, 23, 8, 30, 00), new DateTime(2023, 01, 24, 12, 00, 00));

        Day day1 = new Day(23, new[] {evento1, evento2});
        Day day2 = new Day(24, new[] {evento3, evento4});

        Calendars calendar1 = new Calendars("Ciclo1 .Net", new[] {day1, day2});

        Console.WriteLine(calendar1.ToString());
    }
}
