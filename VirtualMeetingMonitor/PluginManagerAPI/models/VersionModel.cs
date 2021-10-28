using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMeetingMonitor.PluginManager.models
{
    public class VersionModel
    {
        public VersionModel(string version, string unique_id, string file_version, string crc, string hash)
        {
            Version = version;
            Unique_id = unique_id;
            File_version = file_version;
            Crc = crc;
            Hash = hash;
        }
        public VersionModel()
        {

        }

        public string Version { get; set; } 
        public string Unique_id { get; set; }

        public string File_version { get; set; }

        public string Crc { get; set; }

        public string Hash { get; set; }



    }
}
