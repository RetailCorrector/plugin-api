using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Loader;

namespace RetailCorrector
{
    public abstract class AbstractFiscalModule
    {
        public event Action<bool, string, Exception?>? OnLog;
        public event Action<string>? OnNotify;
        public event PropertyChangedEventHandler? PropertyChanged;
        public event Action<int>? Started;
        public event Action<int>? ProgressUpdated;

        protected internal void Log(bool isError, string message, Exception? exception = null) =>
            OnLog?.Invoke(isError, message, exception);
        protected internal void Notify(string message) => OnNotify?.Invoke(message);
        protected internal void OnStarted(int maxProgress) => Started?.Invoke(maxProgress);
        protected internal void OnProgressUpdated(int value) => ProgressUpdated?.Invoke(value);
        protected internal void OnPropertyChanged([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public abstract Task<uint> CountUnsendDocs();
        public abstract Task OnLoad(AssemblyLoadContext assembly);
        public abstract Task<bool> Connect();
        public abstract Task<bool> ProcessingReceipt(Receipt receipt);
        public abstract Task OnUnload();
    }
}
