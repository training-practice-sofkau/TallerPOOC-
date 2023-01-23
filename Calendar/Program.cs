using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
	class Program
	{
		//se inicializa el menu y el manejo de excepciones 
		public Program()
		{
			try
			{
				menu();
			}catch (Exception)
			{
				Console.WriteLine("Dato invalido");
			}
		}

		private void menu()
		{
			//Instancia de las clases Day y Calendar para usar sus metodos posteriormente 
			Day dia = new Day();
			Calendar calendario = new Calendar();
			int opcion;
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

				//pide datos al usuario y los envia a la clase calendar para agregarlos
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

					//crea un nuevo evento y lo agrega al calendario
					Calendar nuevoEvento = new(nombre, fechaInicio, fechaFinal);
					calendario.agregarEvento(nuevoEvento);
				}
				else if (opcion == 2)
				{
					//ejecuta la funcion mostrarEventos la cual recibe una lista filtrada por dia de la lista de eventos del calendario
					mostrarEventos(dia.mostrarEventos(calendario.mostrarEventos()));
				}
				else if (opcion == 3)
				{
					//Toma la fecha actual para filtrar la lista y mostrarla
					DateTime diaActual = DateTime.Now;
					mostrarDias(calendario.filtrarDias(diaActual.Month, diaActual.Year));
					
				}
				else if (opcion == 4)
				{
					int mes;
					int año;

					//Toma los datos del usuario para realizar el filtro por año y mes
					Console.WriteLine("Digite el año a consultar: ");
					año = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Digite el mes a consultar: ");
					mes = Convert.ToInt32(Console.ReadLine());

					//Muestra la lista filtrada por el mes y el año que el usuario digito
					mostrarDias(calendario.filtrarDias(mes, año));
				}
				else
				{
					Console.WriteLine("Opcion incorrecta. ");
				}

			} while (opcion > 0 && opcion < 5);

		} 

		public void mostrarDias(List<Event> calendario)
		{
			Console.WriteLine("-----------------------  Eventos del mes ------------------------------");
			foreach (Event evento in calendario)
			{
				Console.WriteLine("El evento {0} esta agendado para el {1} del mes {2}. ", evento.Name,evento.StartDate.Day, evento.StartDate.Month);
				Console.WriteLine("-----------------------------------------------------------------------");
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

			/*
			 
			//Instancia de la fecha actual
			DateTime diaActual = DateTime.Now;

			//Instancia de la clase Calendar
			Calendar calendario= new Calendar();
			Day dia= new Day();

			//Se realiza la instancia de los nuevos eventos
			Calendar evento1= new Calendar("evento1",new DateTime(2023,01,01), new DateTime(2023,01,02));
			Calendar evento2= new Calendar("evento2",new DateTime(2022,01,01), new DateTime(2022,01,02));
			Calendar evento3= new Calendar("evento3",new DateTime(2023,01,22), new DateTime(2023,01,22));
			Calendar evento4= new Calendar("evento4",new DateTime(2023,02,22), new DateTime(2022,02,23));

			//Se agregan los eventos al calendario
			calendario.agregarEvento(evento1);
			calendario.agregarEvento(evento2);
			calendario.agregarEvento(evento3);
			calendario.agregarEvento(evento4);

			//se obtiene los eventos del dia actual
			programa.mostrarEventos(dia.mostrarEventos(calendario.mostrarEventos()));

			//Se obtiene los dias con eventos en el mes
			programa.mostrarDias(calendario.filtrarDias(diaActual.Month, diaActual.Year));

			//Se obtiene los dias con eventos de un mes especificado por el usuario
			programa.mostrarDias(calendario.filtrarDias(02, 2023));

			*/

		}
	}
}
