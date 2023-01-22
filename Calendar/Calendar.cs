using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Calendar
{
    /// <summary>
    /// Clase representativa de un calendario
    /// </summary>
    internal class Calendar
    {

        private string month;
        private List<Day> listDay;

        /// <summary>
        /// Metodo encargado de administrar el nombre del mes de un calendario.
        /// </summary>
        public string Month
        {
            get { return month; }
            set { month = value; }
        }
       
        /// <summary>
        /// Metodo encargado de administrar listas de dias los cuales a su vez contienen listas de eventos
        /// </summary>
        public List<Day> ListDay
        {
            get { return listDay; }
            set { listDay = value; }
        }

        /// <summary>
        /// Metodo constructor
        /// </summary>
        /// <param name="month">Nombre del mes de un calendario</param>
        /// <param name="listDay">lista de dias con eventos</param>
        public Calendar(string month, List<Day>  listDay)
        {
            Month= month;
           
            ListDay = listDay;
        }
    }
}
