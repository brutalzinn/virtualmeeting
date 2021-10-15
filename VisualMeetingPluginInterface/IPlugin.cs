using System;

namespace VisualMeetingPluginInterface
{
    public interface IPlugin
    {
        string GetName();

        string GetPlaceHolder();

        string Main();
    }
}
