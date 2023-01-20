using System.Net.NetworkInformation;

namespace Calendar {

    internal class Program {

        static void Main(string[] args)
        {

            string reply;
            string nameFirstEvent;
            DateTime startEvent;
            DateTime endEvent;
           
    

                Console.WriteLine("Bienvenido a tu calendario");
                Console.WriteLine("Quisieras agregar un evento?");
                reply = Console.ReadLine();
                Console.WriteLine("Como nombraras el evento?");
                nameFirstEvent = Console.ReadLine();
                Console.WriteLine("Que fecha de inicio estaria bien para el evento?");
                startEvent =DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Que fecha de finalizacion estaria bien para el evento?");
                endEvent =DateTime.Parse(Console.ReadLine());
                Event firstEvent = new Event(nameFirstEvent, startEvent, endEvent);
                Console.WriteLine(firstEvent.Name);











        }

    }

}




