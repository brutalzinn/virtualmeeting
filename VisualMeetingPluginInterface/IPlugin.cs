using System;
using System.Collections.Generic;

namespace VisualMeetingPluginInterface
{
    public interface IPlugin
    {
        string GetName();

        string Description();

        string Authors();

        string Contact();

        string GetPlaceHolder();

        Dictionary<string, Func<string>> GetMultipleHolder();

        string Main();
    }
}
