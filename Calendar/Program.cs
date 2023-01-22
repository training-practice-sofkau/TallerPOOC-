using System.Net.NetworkInformation;

namespace Calendar {

    /// <summary>
    ///  Clase encargada de ejecutar el programa, instaciar objetos  y almacenar dias con eventos en un calendario 
    /// </summary>
    internal class Program {

        
        static void Main(string[] args){
            /*
             *Variable encargada de ejecutar o detener el proceso del programa
             */
            int reply;

            /*
             * Variable donde se almacenara el nombre de los eventos creados
             */
            string nameFirstEvent;
            /*
             *Variable encargada de almacenar el nombre del mes que quiere visualizar el ususario
             */
            string nameMonthOption;
            /*
             * Variable encargada de almacenar la fecha de inicio del evento
             */
            DateTime startEvent;
            /*
             *Variable encargada de almacenar la fecha de  finalizacion del evento
             */
            DateTime endEvent;

            /*
             * Variable encargada de almacenar la hora de inicio del evento
             */
            DateTime startEventFinally;
            /*
             * Variable encargada de almacenar la hora de finalizacion del evento 
             */
            DateTime endEventFinally;
            /*
             *Variable encargada de almacenar la fecha completa con horas de inicio del evento
             */
            DateTime dateCompleteFinallyEnd;

            /*
             *Variable encargada de almacenar la fecha completa con horas de finalizacion del evento
             */
            DateTime dateCompleteFinallyStart;

            /*
             *Lista encargada de almacenar eventos
             */
            List<Event> firstListEvent = new();
            /*
             *Lista encargada de almacenar dias
             */
            List<Day> firstListDay = new();

                Console.WriteLine("Bienvenido a tu calendario");
                Console.WriteLine("Que te gustaria hacer hoy?");
                Console.WriteLine("1. AGREGAR UN EVENTO." +
                    " 0 SALIR APLICACION");
                reply = int.Parse(Console.ReadLine());

                    while (reply == 1){
                        //Asignacion de nombre al evento
                        Console.WriteLine("Como se llamara el evento?");
                        nameFirstEvent = Console.ReadLine();

                        //Asignacion de fecha de inicio del evento 
                        Console.WriteLine("Que fecha de inicio estaria bien para el evento?");
                        startEvent = DateTime.Parse(Console.ReadLine());

                        //Asignacion de hora de inicio del evento
                        Console.WriteLine("Que hora estaria bien para comenzar el evento?");
                        startEventFinally = DateTime.Parse(Console.ReadLine());

                        //Asignacion de fecha de finalizacion del evento
                        Console.WriteLine("Que fecha de finalizacion estaria bien para el evento?");
                        endEvent = DateTime.Parse(Console.ReadLine());

                        //Asignacion de hora de finalizacion del evento
                        Console.WriteLine("Que hora estaria bien finalizar el evento?");
                        endEventFinally = DateTime.Parse(Console.ReadLine());

                        //Asignacion de fecha completa con horas de inicio del evento
                        dateCompleteFinallyStart = startEvent.AddHours(startEventFinally.Hour).AddMinutes(startEventFinally.Minute);

                        //Asignacion de fecha completa con horas de la finalizacion del evento
                        dateCompleteFinallyEnd = endEvent.AddHours(endEventFinally.Hour).AddMinutes(endEventFinally.Minute);

                        //Creacion del objeto evento y almacenamiento en la lista de objetos de tipó evento
                        Event firstEvent = new Event(nameFirstEvent, dateCompleteFinallyStart, dateCompleteFinallyEnd);
                        firstListEvent.Add(firstEvent);
                        Console.WriteLine("Evento guardado con exíto");

                        //Creacion de un objeto tipo de dato dia, que contiene lista de eventos y almacenamiento de dias en la lista de tipo de dato dia
                        Day dayfirst = new Day(startEvent.Day, firstListEvent, startEvent.ToString("dddd"));
                        firstListDay.Add(dayfirst);

                        //Creacion de un objeto de tipo calendario , que asu vez contiene listas de tipo dia las cuales contienen listas con eventos
                        Calendar calendarFirst = new Calendar(startEvent.ToString("MMMM"), firstListDay);


                        Console.WriteLine("Deseas ver tu calendario con los eventos o quisieras agregar otro evento?");
                        Console.WriteLine("Presiona 1 si quieres agregar un evento nuevo ó presiona 0 para ver tus eventos");
                        //Variable controladora del ciclo , encargada de mostrar o agregar eventos
                        reply = int.Parse(Console.ReadLine());

                        if (reply != 1){
                            //Asignacion del nombre del mes el cual queremos visualizar eventos
                            Console.WriteLine("¿Escribe cual mes  te gustaria revisar?, si contiene o no eventos");
                            nameMonthOption = Console.ReadLine();

                            ///Ciclo encargado de recorer el tamaño de la lista que almacena los dias 
                            for (int i = 0; i < firstListDay.Count; i++){

                                //Busqueda de eventos  que inician con fecha similar a la digitada por el ususario
                                if (nameMonthOption == calendarFirst.ListDay[i].ListEvent[i].StartDate.ToString("MMMM"))
                                {
                                    //Impresion en pantalla de los eventos los cuales representen el mes escrito por el usuario
                                    Console.WriteLine(calendarFirst.ListDay[i].ListEvent[i].ToString());
                                }

                            }
                            Console.WriteLine("Feliz resto de día");
                        }
                    }
          
        }

    }

}




