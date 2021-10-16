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

 
        Dictionary<string, Func<string>> GetPlaceHolder();


        // needs be optional.

        Dictionary<string, Func<object, dynamic>> Interfaces();

        string getConfigData();

        void loadConfigData(dynamic data = null);
    }

    

    }
