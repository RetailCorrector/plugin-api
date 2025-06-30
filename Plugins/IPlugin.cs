using System.Runtime.Loader;

namespace RetailCorrector.Plugins;

public interface IPlugin
{
    /// <summary>
    /// Наименование плагина
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Событие логирования
    /// </summary>
    event Action<string, bool, Exception?>? Logging;

    /// <summary>
    /// Действие при загрузке плагина
    /// </summary>
    /// <param name="ctx">Контекст загрузки сборок</param>
    Task OnLoad(AssemblyLoadContext ctx);
    /// <summary>
    /// Действие при выгрузке плагина
    /// </summary>
    Task OnUnload();
}