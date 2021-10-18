using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMeetingMonitor.ApiPluginManager.models
{
    public class FileModel
    {
        public string Filename { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public dynamic User { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public string Repository { get; set; }
    }
}
