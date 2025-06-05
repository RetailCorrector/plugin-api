using System.Runtime.Loader;

namespace RetailCorrector.Plugin;

public interface IPlugin
{
    event Action<string, bool, Exception> Logging;
    event Action<string, string?> Notification;

    Task OnLoad(AssemblyLoadContext ctx);
    Task OnUnload(AssemblyLoadContext ctx);
}