using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    /// <summary>
    /// Clase  la cual representa un evento  o tarea en un calendario.
    /// </summary>
    internal class Event
    {
        //Por buenas practicas no comentamos estas variables.
        private string name;
        private DateTime startDate;
        private DateTime endDate;

        /// <summary>
        /// Metodo encargado de administrar el nombre del  un evento.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        ///  Metodo encargado de administrar la fecha de inicio de un evento
        /// </summary>
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        /// <summary>
        ///  Metodo encargado de administrar la fecha de finalizacion de un evento
        /// </summary>
        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        /// <summary>
        /// Metodo contructor
        /// </summary>
        /// <param name="name"> Nombre del evento</param>
        /// <param name="startDate">Fecha de inicio del evento</param>
        /// <param name="endDate">Fecha de finalizacion del evento</param>
        public Event(string name, DateTime startDate, DateTime endDate)
        {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
        }

        /// <summary>
        /// Metodo encargado de mostrar en pantalla el evento completo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $" El evento: '{Name}' Inicia el: {StartDate.ToLongDateString()} a las {StartDate.ToString("hh:mm tt")}  y finaliza el: {EndDate.ToLongDateString()} a las {EndDate.ToString("hh:mm tt")}";
        }
    }
}