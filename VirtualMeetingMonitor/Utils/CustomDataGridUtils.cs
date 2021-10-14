using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMeetingMonitor.Utils
{
    public class CustomDataGridUtils
    {
        public Dictionary<int, string> List = new Dictionary<int, string>();
        public bool Enabled { get; set; } = true;

        public CustomDataGridUtils(Dictionary<int, string> list, bool enabled)
        {
            List = list;
            Enabled = enabled;
        }


    }
}
