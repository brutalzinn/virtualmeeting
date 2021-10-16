using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualMeetingMonitor.Utils;

namespace VirtualMeetingMonitor
{
   public class Profile
    {

        public string Name { get; set; }
        public string GoogleKey { get; set; }
        public string SheetId { get; set; }

        public bool DevMode { get; set; } = false;


        public string UniqueId { get; set; }

        public CustomDaysUtils CustomDays { get; set; }

        public CustomDataGridUtils CustomDataGrid { get; set; }


        public List<object> PluginsSettings = new List<object>();

        public string CustomTime { get; set; }

        public int Timeout { get; set; }

        public string Language { get; set; }
        public Profile(string name, string googleKey, string sheetId, string customTime, int timeout, string language)
        {
            UniqueId = Guid.NewGuid().ToString("N");
            Name = name;
            GoogleKey = googleKey;
            SheetId = sheetId;
            CustomTime = customTime;
            Timeout = timeout;
            Language = language;
        }
        public override string ToString()
        {
            return Name;
        }






        }
}
