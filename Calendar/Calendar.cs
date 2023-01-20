using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Calendar
{
    internal class Calendar
    {

        private string month;
        private List<Day> listDay;


        public string Month
        {
            get { return month; }
            set { month = value; }
        }
       

        public List<Day> ListDay
        {
            get { return listDay; }
            set { listDay = value; }
        }


        public Calendar(string month, List<Day>  listDay)
        {
            Month= month;
           
            ListDay = listDay;
        }

    
    }
}
