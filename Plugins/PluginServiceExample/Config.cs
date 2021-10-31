using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginServiceExample
{
    public class Config
    {

        public bool Enabled { get; set; }

        public string SpreadsheetId { get; set; }

        public string sheet { get; set; }

        public Config(bool enabled)
        {
            Enabled = enabled;
        }

        public Config()
        {

        }

      
    }
}
