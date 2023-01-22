using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
	internal class Calendar : Event
	{
		private List<Calendar> diasFiltrados;
		private List<Event> eventos = new List<Event>();
		private DateTime diaActual;
	
		public List<Calendar> filtrarDias(int mes, int año)
		{
			diasFiltrados = new List<Calendar>();
			diaActual = DateTime.Now;
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
