using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMeetingMonitor.PluginManagerAPI.models
{
    public class PluginUpdateRequest
    {
        public PluginUpdateRequest(string unique_id)
        {
            this.unique_id = unique_id;
        }

        public string unique_id { get; set; }

    
    }
}
