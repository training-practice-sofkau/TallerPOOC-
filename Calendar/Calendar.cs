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
        private int dayMonth;
        private List<Day> listDay;


        public string Month
        {
            get { return month; }
            set { month = value; }
        }
        public int DayMonth
        {
            get { return dayMonth; }
            set { dayMonth = value; }
        }

        public List<Day> ListDay
        {
            get { return listDay; }
            set { listDay = value; }
        }


        public Calendar(string month,int dayMonth, List<Day>  listDay)
        {
            Month= month;
            DayMonth= dayMonth;
            ListDay = listDay;
        }

        public Calendar()
        {
        }
    
    
    }
}
