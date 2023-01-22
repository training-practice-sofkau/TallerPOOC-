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
		private List<Event> eventosFiltrados;
		private DateTime diaActual;

		public List<Event> mostrarEventos(List<Event> lista)
		{
			eventosFiltrados = new List<Event>();
			diaActual = DateTime.Now;
			foreach (Event evento in lista)
			{
				if (evento.StartDate.DayOfYear == diaActual.DayOfYear && evento.StartDate.Year == diaActual.Year)
				{
					eventosFiltrados.Add(evento);
				}
			}
			return eventosFiltrados;
		}
		public Day()
		{
		}

	}
}