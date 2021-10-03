using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMeetingMonitor
{
    public  class Globals
    {
       public static List<Language> languages = new List<Language>();
        public static Form form { get; set; }
       public static Language CurrentLanguage { get; set; }
        public static string getKey(string key)
        {
            return CurrentLanguage.getValue(key);
        }
    }
}
