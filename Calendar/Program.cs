using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
	class Program
	{
		Day dia;

		//se instancian los objetos y se inicializa el menu
		public Program()
		{
			dia = new Day();
			menu();
		}

		private void menu()
		{
			int opcion = 0;

			do
			{
				Console.WriteLine("--------------------  Calendario de Eventos ---------------------------");
				Console.WriteLine("Menu:    ");
				Console.WriteLine("1. Nuevo Evento.");
				Console.WriteLine("2. Consultar Eventos del dia. ");
				Console.WriteLine("3. Consultar Calendario de eventos. ");
				Console.Write("----> ");

				opcion = Convert.ToInt32(Console.ReadLine());

				if (opcion == 1)
				{
					dia.agregarEvento();
				}else if(opcion == 2)
				{
					mostrarEventos(dia.mostrarEventos());
				}
				else
				{
					Console.WriteLine("Opcion incorrecta. ");
				}

			} while (opcion > 0 && opcion < 3);

		}
		
		public void mostrarEventos(List<Event> eventos)
		{
			Console.WriteLine("-----------------------  Eventos del dia ------------------------------");

			foreach (Day evento in eventos)
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
		}
	}
}
