using System.Runtime.Loader;

namespace RetailCorrector.Plugin
{
    public abstract class FiscalPlugin: IPlugin
    {
        public abstract string Name { get; }
                
        public event Action<string, bool, Exception>? Logging;
        public event Action<string, string?>? Notification;
        
        protected internal void Log(string text, bool error, Exception ex) => Logging?.Invoke(text, error, ex);
        protected internal void Notify(string text, string? caption = null) => Notification?.Invoke(text, caption);
        
        public abstract Task OnLoad(AssemblyLoadContext ctx);
        public abstract Task<bool> Connect();
        public abstract Task<uint> CountDocsInBuffer();
        public abstract Task<bool> ProcessingReceipt(Receipt receipt);
        public abstract Task Disconnect();
        public abstract Task OnUnload(AssemblyLoadContext ctx);
    }
}
