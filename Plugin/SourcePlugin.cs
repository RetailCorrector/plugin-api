using System.Runtime.Loader;

namespace RetailCorrector.Plugin
{
    public abstract class SourcePlugin: IPlugin
    {
        public event Action<string, bool, Exception>? Logging;
        public event Action<string, string?>? Notification;
        public event Action<int>? ParseStarted;
        public event Action<int>? ProgressUpdated;
        
        protected internal void OnParseStarted(int maxProgress) => ParseStarted?.Invoke(maxProgress);
        protected internal void OnProgressUpdated(int value) => ProgressUpdated?.Invoke(value);
        protected internal void Log(string text, bool error, Exception ex) => Logging?.Invoke(text, error, ex);
        protected internal void Notify(string text, string? caption = null) => Notification?.Invoke(text, caption);

        public abstract Task OnLoad(AssemblyLoadContext ctx);
        public abstract Task OnUnload(AssemblyLoadContext ctx);
        
        public abstract Task<IEnumerable<Receipt>> Parse(CancellationToken token);
    }
}
