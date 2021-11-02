using PluginInterface;
using System;
using System.Diagnostics;

namespace PluginEventExample
{
    public class PluginEventExample : IEvent
    {
        public string Authors()
        {
            return "robertinho.net";
        }

        public string Contact()
        {
            return "robertinho.net";
        }

        public string Description()
        {
            return "Essa é uma descrição";
        }

        public string Name()
        {
            return "PluginEventExample";
        }

       public void Meeting_OnMeetingStarted()
        {
            Debug.WriteLine("Olha, a chamada começou");
        }

        public void Meeting_OnMeetingEnded()
        {
            Debug.WriteLine("Olha, a chamada terminou");
        }

    }
}
