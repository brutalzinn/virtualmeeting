using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMeetingMonitor.PluginManager.models
{
    public class GenericFiles
    {
        public int totalItems { get; set; }

        public List<FileModel> files = new List<FileModel>();
        public int totalPages { get; set; }
        public int currentPage { get; set; }

    }
}
