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

        public CustomDaysUtils(List<int> days, string noDaysMessage, string daysMessage, bool enabled = true)
        {
            Days = days;
            NoDaysMessage = noDaysMessage;
            DaysMessage = daysMessage;
            Enabled = enabled;
        }

        public string NoDaysMessage { get; set; }

        public string DaysMessage { get; set; }

        public bool Enabled { get; set; } = true;

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
