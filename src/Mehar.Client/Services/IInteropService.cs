namespace Mehar.Client.Services;

internal interface IInteropService
{
    Task<bool> IsDarkMode();
    Task<T?> GetItem<T>(string key);
    Task SetItem<T>(string key, T value);
    Task RemoveItem(string key);
    Task ClearItems();
}
