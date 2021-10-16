using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginExampleWithInterface
{
  public  class Globals
    {
        public static Config _Config { get; set; } = new Config("");

        public static void saveConfig(Config data)
        {
             _Config = data;
        }
    }
}
