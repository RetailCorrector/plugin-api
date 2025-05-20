namespace RetailCorrector
{
    public abstract class AbstractFiscalModule
    {
        public event Action<bool, string, Exception?>? OnLog;
        public event Action<string>? OnNotify;

        protected internal void Log(bool isError, string message, Exception? exception = null) =>
            OnLog?.Invoke(isError, message, exception);
        protected internal void Notify(string message) => OnNotify?.Invoke(message);

        public abstract Task<bool> OnLoad();
        public abstract Task<bool> ProcessingReceipt(Receipt receipt);
        public abstract Task OnUnload();
    }
}
