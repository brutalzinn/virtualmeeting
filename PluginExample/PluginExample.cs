using System;
using VisualMeetingPluginInterface;

namespace PluginExample
{
    internal class PluginExample : IPlugin
    {
        public string GetName() => "My plugin v1";


        public string GetPlaceHolder() => "PLUGINEXAMPLE";


        public string Main()
        {
            return "This is just a example of a plugin.";
        }

        
    }
}
