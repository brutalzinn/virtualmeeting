using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMeetingMonitor.Utils
{
    public class CustomDaysUtils
    {
        public List<int> Days = new List<int>();

        public CustomDaysUtils(List<int> days, string noDaysMessage, string daysMessage)
        {
            Days = days;
            NoDaysMessage = noDaysMessage;
            DaysMessage = daysMessage;
        }

        public string NoDaysMessage { get; set; }

        public string DaysMessage { get; set; }

        public string checkToday()
        {
            DateTime thisDay = DateTime.Today;
            int todayName = (int)thisDay.DayOfWeek;
            Console.WriteLine("\n TODAY: " + todayName);
            if (Days.Contains(todayName))
            {
                return DaysMessage;
            }
            else
            {
                return NoDaysMessage;
            }

        }

    }
}
