using System.Net.NetworkInformation;

namespace Calendar {

    internal class Program {

        static void Main(string[] args)
        {

            string reply;
            string nameFirstEvent;
            DateTime startEvent;
            DateTime endEvent;
            DateTime startEventFinally;
            DateTime endEventFinally;
            List<Event> firstListEvent = new();
            List<Day> firstListDay = new();

            //Console.WriteLine("Bienvenido a tu calendario");
            //Console.WriteLine("Quisieras agregar un evento?");
            //reply = Console.ReadLine();

                Console.WriteLine("Como nombraras el evento?");
                 nameFirstEvent = Console.ReadLine();
                 Console.WriteLine("Que fecha de inicio estaria bien para el evento?");
                startEvent = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Que hora estaria bien para comenzar el evento");
                startEventFinally = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Que fecha de finalizacion estaria bien para el evento?");
                endEvent =DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Que hora estaria bien finalizar el evento");
                endEventFinally = DateTime.Parse(Console.ReadLine());
                Event firstEvent = new Event(nameFirstEvent,startEvent, endEvent);
                firstListEvent.Add(firstEvent);
                Console.WriteLine("Evento guardado con exíto");
                Day dayfirst = new Day(startEvent.Day,firstListEvent,startEvent.ToString("dddd"));
                firstListDay.Add(dayfirst);
                Calendar calendarFirst = new Calendar(startEvent.ToString("MMMM"),firstListDay);

            Console.WriteLine(firstListDay[0].ToString() + firstEvent.ToString());
            
            //Console.WriteLine("De cual mes te gustaria saber tus eventos");
                    
                
           
                

                
            // Console.WriteLine(firstEvent.ToString()+$" de {startEventFinally.ToString("h:mm tt")} hasta las {endEventFinally.ToString("h:mm tt")}");
                //Console.WriteLine(firstListEvent[0]);









        }

    }

}




