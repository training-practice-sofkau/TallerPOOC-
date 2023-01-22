using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
	internal class Day : Event
	{
		private List<Event> eventos = new List<Event>();
		private List<Event> eventosFiltrados;
		private DateTime diaActual;

		public void agregarEvento()
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

			Day nuevoEvento = new(nombre, fechaInicio, fechaFinal);
			eventos.Add(nuevoEvento);
		}

		public List<Event> mostrarEventos()
		{
			eventosFiltrados = new List<Event>();
			diaActual = DateTime.Now;
			foreach (Day evento in eventos)
			{
				if (evento.StartDate.DayOfYear == diaActual.DayOfYear && evento.StartDate.Year == diaActual.Year)
				{
					eventosFiltrados.Add(evento);
				}
			}
			return eventosFiltrados;
		}

		public Day(string name, DateTime startDate, DateTime endDate) : base(name, startDate, endDate)
		{
		}
		public Day()
		{
		}

	}
}