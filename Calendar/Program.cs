using System.Net.NetworkInformation;

namespace Calendar {

    internal class Program {

        static void Main(string[] args)
        {

            int reply;
            string nameFirstEvent;
            string nameMonthOption;
            DateTime startEvent;
            DateTime endEvent;
            DateTime startEventFinally;
            DateTime endEventFinally;
            List<Event> firstListEvent = new();
            List<Day> firstListDay = new();

            //Console.WriteLine("Bienvenido a tu calendario");
            //Console.WriteLine("Quisieras agregar un evento?");
            //reply = Console.ReadLine();

                //Console.WriteLine("Como nombraras el evento?");
                // nameFirstEvent = Console.ReadLine();
                // Console.WriteLine("Que fecha de inicio estaria bien para el evento?");
                //startEvent = DateTime.Parse(Console.ReadLine());
                //Console.WriteLine("Que hora estaria bien para comenzar el evento");
                //startEventFinally = DateTime.Parse(Console.ReadLine());
                //Console.WriteLine("Que fecha de finalizacion estaria bien para el evento?");
                //endEvent =DateTime.Parse(Console.ReadLine());
                //Console.WriteLine("Que hora estaria bien finalizar el evento");
                //endEventFinally = DateTime.Parse(Console.ReadLine());
                //Event firstEvent = new Event(nameFirstEvent,startEvent, endEvent);
                //firstListEvent.Add(firstEvent);
                //Console.WriteLine("Evento guardado con exíto");
                //Day dayfirst = new Day(startEvent.Day,firstListEvent,startEvent.ToString("dddd"));
                //firstListDay.Add(dayfirst);
                //Calendar calendarFirst = new Calendar(startEvent.ToString("MMMM"),firstListDay);

                //Console.WriteLine("Desea ver su calendario con eventos o quisiera agregar otro evento?");
                //Console.WriteLine("Presione 1 si quiere agregar otro evento ó presione 0 para ver sus eventos");
                //reply =int.Parse (Console.ReadLine());

            do
            {


                Console.WriteLine("Como nombraras el evento?");
                nameFirstEvent = Console.ReadLine();
                Console.WriteLine("Que fecha de inicio estaria bien para el evento?");
                startEvent = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Que hora estaria bien para comenzar el evento");
                startEventFinally = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Que fecha de finalizacion estaria bien para el evento?");
                endEvent = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Que hora estaria bien finalizar el evento");
                endEventFinally = DateTime.Parse(Console.ReadLine());
                 DateTime dateCompleteFinallyStart = startEvent.AddHours(startEventFinally.Hour).AddMinutes(startEventFinally.Minute);
                 DateTime dateCompleteFinallyEnd =endEvent.AddHours(endEventFinally.Hour).AddMinutes(endEventFinally.Minute);
                Event firstEvent = new Event(nameFirstEvent, dateCompleteFinallyStart, dateCompleteFinallyEnd);
                firstListEvent.Add(firstEvent);
                Console.WriteLine("Evento guardado con exíto");
                Day dayfirst = new Day(startEvent.Day, firstListEvent, startEvent.ToString("dddd"));
                firstListDay.Add(dayfirst);
                Calendar calendarFirst = new Calendar(startEvent.ToString("MMMM"), firstListDay);
                Console.WriteLine("Deseas ver tu calendario con eventos o quisiera agregar otro evento?");
                Console.WriteLine("Presiona 1 si quieres agregar otro evento ó presione 0 para ver tus eventos");
                reply = int.Parse(Console.ReadLine());

                if (reply != 1) {

                    Console.WriteLine("Cual mes de tu calendario te gustaria revisar?");
                    nameMonthOption = Console.ReadLine();

                    for (int i = 0; i < firstListDay.Count; i++)
                    {

                        if (nameMonthOption == calendarFirst.ListDay[i].ListEvent[i].StartDate.ToString("MMMM"))
                        {
                          
                            Console.WriteLine(calendarFirst.ListDay[i].ListEvent[i].ToString());
                            

                        }

                    }
                 
                }
     

            } while (reply == 1);

         

            // Console.WriteLine(firstListDay[0].ToString() + firstEvent.ToString());



            /*
            Este es el metodo que me busca e imprime el evento buscado en el calendario 
            */
            // Console.WriteLine(calendarFirst.ListDay[0].ListEvent[0].Name);




            // Console.WriteLine(firstEvent.ToString()+$" de {startEventFinally.ToString("h:mm tt")} hasta las {endEventFinally.ToString("h:mm tt")}");
            //Console.WriteLine(firstListEvent[0]);




        }

    }

}




