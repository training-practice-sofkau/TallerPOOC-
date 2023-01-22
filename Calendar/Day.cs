using System.Collections.Generic;

namespace Calendar
{
/// <summary>
/// Clase la cual representa  los dias contenidos en los meses
/// </summary>
    internal class Day
    {

        private string nameDay;
        private int dayNumber;
        private  List<Event> listEvent;

        /// <summary>
        ///  Metodo encargado de administrar el nombre de un dia.
        /// </summary>
        public string Name {

            get { return nameDay; }
            set { nameDay = value; }
        
        }

        /// <summary>
        ///  Metodo encargado de administrar el numero del dia.
        /// </summary>
        public int DayNumber {

            get { return dayNumber; }

            set { dayNumber  = value; }
        }


        /// <summary>
        ///  Metodo encargado de administrar eventos  generados en un dia.
        /// </summary>
        public List<Event> ListEvent {

            get { return listEvent; }

            set { listEvent = value; }
        
        }

        /// <summary>
        /// Metodo constructor
        /// </summary>
        /// <param name="dayNumber">Numero de dia</param>
        /// <param name="listEvent">Lista de eventos en un dia</param>
        /// <param name="name">Nombre del dia</param>
        public Day(int dayNumber, List<Event> listEvent, string name)
        {
            Name = name;
            DayNumber = dayNumber;
            ListEvent = listEvent;
        }
    }
}
