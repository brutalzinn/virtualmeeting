using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginExampleWithInterface
{
    public class Config
    {
        public string TextBoxValue { get; set; }
        public Config(string textBoxValue)
        {
            TextBoxValue = textBoxValue;
        }

        public Config()
        {

        }
       
    }
}
