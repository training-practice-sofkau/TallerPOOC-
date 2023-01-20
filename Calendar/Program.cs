using Calendar;
using System;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Globalization;
using System.Linq.Expressions;

class Program
{

    // Main Method
    static void Main(string[] args)
    {
        string nameEvent;
        DateTime startEvent;
        DateTime endEvent;

        List<Event> eventsList = new();
        List<Day> daysList = new();
        Day day;
        Calendary[] calendary = new Calendary[31];
        int dayEvents = 0;

        int op = 0;
        Console.WriteLine("CALENDARIO");

        do
        {
            Console.WriteLine("\n1. Agregar evento al calendario. \n0. salir.");
            string inputOp = Console.ReadLine();

            if (inputOp != "" && inputOp != null)
            {
                op = Int16.Parse(inputOp);
            }
            switch (op)
            {
                case 1:
                    Console.WriteLine("AGREGANDO EVENTOS A UN UNICO DEL DIA CALENDARIO");
                    Console.WriteLine("\nRegalanos la siguiente informacion:\n" +
                        "¿Nombre del evento?");
                    nameEvent = Console.ReadLine();

                    if (dayEvents == 0)
                    {
                        Console.WriteLine("¿Que dia es el evento? Ej: 21");
                        dayEvents = Int16.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("¿Fecha inicio del evento? dd-mm-yy");
                    startEvent = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("¿Fecha fin del evento? dd-mm-yy");
                    endEvent = DateTime.Parse(Console.ReadLine());

                    // creo el evento con los datos recibidos
                    Event eventToCreate = new(nameEvent, startEvent, endEvent);
                    Console.WriteLine("\n¡Evento creado!");

                    if (eventToCreate != null)
                    {
                        //anado los eventos a la lista para guardarlos en el mismo dia
                        eventsList.Add(eventToCreate);
                    }
                    break;
                default:
                    break;
            }
        } while (op != 0);

        //agrego la lista de eventos al dia
        day = new(eventsList);
        Console.WriteLine("\n" + day.EventsDay.Count + " Eventos en el dia");

        //agrego el dia al calendario
        calendary[dayEvents - 1] = new Calendary(day);
        for (int i = 0; i < calendary.Length; i++)
        {
            if (calendary[i] != null)
            {
                Console.WriteLine("\nDia: " + (i + 1) + " > " + calendary[i].DaysMonth.EventsDay.Count + " Eventos en el dia");
            }
            else
            {
                Console.WriteLine("--");
            }
        }

        Console.WriteLine("Fin");
    }
}
