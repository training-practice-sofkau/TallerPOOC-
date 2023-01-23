using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
	internal class Calendar : Event
	{
		private List<Event> diasFiltrados;
		private List<Event> eventos = new List<Event>();
	
		public List<Event> filtrarDias(int mes, int año)
		{
			diasFiltrados = new List<Event>();
			foreach (Calendar evento in eventos)
			{
				if (evento.StartDate.Month == mes && evento.StartDate.Year == año)
				{
					diasFiltrados.Add(evento);
				}
			}
			return diasFiltrados;
		}

		public void agregarEvento(Calendar evento)
		{
			eventos.Add(evento);
		}

		public List<Event> mostrarEventos()
		{
			return eventos;
		}
		
		public Calendar()
		{
		}
		public Calendar(string name, DateTime startDate, DateTime endDate) : base(name, startDate, endDate)
		{
		}
	}
}
