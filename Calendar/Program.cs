using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
	class Program
	{
		private DateTime diaActual;
		//se inicializa el menu
		public Program()
		{
			menu();
		}

		private void menu()
		{
			Day dia = new Day();
			Calendar calendario = new Calendar();
			int opcion = 0;
			do
			{
				Console.WriteLine("--------------------  Calendario de Eventos ---------------------------");
				Console.WriteLine("Menu:    ");
				Console.WriteLine("1. Nuevo Evento.");
				Console.WriteLine("2. Consultar Eventos del dia. ");
				Console.WriteLine("3. Consultar dias con eventos del mes actual. ");
				Console.WriteLine("4. Consultar eventos de un mes. ");
				Console.Write("----> ");

				opcion = Convert.ToInt32(Console.ReadLine());

				if (opcion == 1)
				{
					string nombre = "";
					DateTime fechaInicio = DateTime.Now;
					DateTime fechaFinal = DateTime.Now;

					Console.WriteLine("Digite el nombre del evento: ");
					nombre = Console.ReadLine();
					Console.WriteLine("Digite el fecha de inicio del evento en fomato AAAA/MM/DD: ");
					fechaInicio = Convert.ToDateTime(Console.ReadLine());
					Console.WriteLine("Digite el fecha de final del evento en fomato AAAA/MM/DD: ");
					fechaFinal = Convert.ToDateTime(Console.ReadLine());

					Calendar nuevoEvento = new(nombre, fechaInicio, fechaFinal);
					calendario.agregarEvento(nuevoEvento);
				}
				else if (opcion == 2)
				{
					mostrarEventos(dia.mostrarEventos(calendario.mostrarEventos()));
				}
				else if (opcion == 3)
				{
					diaActual = DateTime.Now;
					mostrarDias(calendario.filtrarDias(diaActual.Month, diaActual.Year));
					
				}
				else if (opcion == 4)
				{

				}
				else
				{
					Console.WriteLine("Opcion incorrecta. ");
				}

			} while (opcion > 0 && opcion < 5);

		}

		public void mostrarDias(List<Event> calendario)
		{
			foreach (Event evento in calendario)
			{
				Console.WriteLine("El evento {0} esta agendado para el {1} de este mes. ", evento.Name,evento.StartDate.Day);
			}
		}
		
		public void mostrarEventos(List<Event> eventos)
		{
			Console.WriteLine("-----------------------  Eventos del dia ------------------------------");

			foreach (Event evento in eventos)
			{
				Console.WriteLine("El evento {0}", evento.Name);
				Console.WriteLine("Inicia el {0}", evento.StartDate.Date);
				Console.WriteLine("Finaliza el {0}", evento.EndDate.Date);
				Console.WriteLine("-----------------------------------------------------------------------");
			}
		}
		static void Main(string[] args)
		{
			//instancia de la clase program para iniciarlo
			Program programa = new Program();
			//DateTime actual= DateTime.Now;
			//Console.WriteLine(actual.Month.ToString());
			/*Calendar calendario= new Calendar();
			Calendar evento1= new Calendar("evento1",new DateTime(2022,12,01), new DateTime(2022,12,02));
			Calendar evento2= new Calendar("evento2",new DateTime(2022,11,01), new DateTime(2022,11,02));
			Calendar evento3= new Calendar("evento3",new DateTime(2022,12,01), new DateTime(2022,12,02));
			Calendar evento4= new Calendar("evento4",new DateTime(2022,10,01), new DateTime(2022,10,02));
			calendario.agregarEvento(evento1);
			calendario.agregarEvento(evento2);
			calendario.agregarEvento(evento3);
			calendario.agregarEvento(evento4);
			foreach (Calendar evento in calendario.filtrarDias(10, 2022))
			{
				Console.WriteLine("El evento {0} esta agendado", evento.Name);
			}*/

		}
	}
}
