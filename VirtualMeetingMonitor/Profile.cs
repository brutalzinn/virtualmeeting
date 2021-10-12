using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMeetingMonitor
{
   public class Profile
    {

        public string Name { get; set; }
        public string GoogleKey { get; set; }
        public string SheetId { get; set; }

        public string CustomTime { get; set; }

        public int Timeout { get; set; }

        public string Language { get; set; }
        public Profile(string name, string googleKey, string sheetId, string customTime, int timeout, string language)
        {
            Name = name;
            GoogleKey = googleKey;
            SheetId = sheetId;
            CustomTime = customTime;
            Timeout = timeout;
            Language = language;
        }

      
    
      

     
    }
}
