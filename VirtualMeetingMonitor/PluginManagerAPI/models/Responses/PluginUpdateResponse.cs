using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMeetingMonitor.PluginManagerAPI.models
{
    public class PluginUpdateResponse
    {

        public string unique_id { get; set; }

        public string version { get; set; }

        public bool status { get; set; }

    }
}
