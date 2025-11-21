using Microsoft.JSInterop;
using System.Text.Json;

namespace Mehar.Client.Services;

internal class InteropService : IInteropService
{
    readonly IJSRuntime _jSRuntime;

    public InteropService(IJSRuntime jsRuntime)
    {
        _jSRuntime = jsRuntime;
    }

    public async Task<bool> IsDarkMode()
    {
        return await _jSRuntime.InvokeAsync<bool>(nameof(IsDarkMode));
    }

    public async Task<T?> GetItem<T>(string key)
    {
        var value = await _jSRuntime.InvokeAsync<string?>(nameof(GetItem), key);
        if (value is null)
            return default;

        return JsonSerializer.Deserialize<T>(value);
    }

    public async Task SetItem<T>(string key, T value)
    {
        var valueJson = JsonSerializer.Serialize(value);
        await _jSRuntime.InvokeVoidAsync(nameof(SetItem), key, valueJson);
    }

    public async Task RemoveItem(string key)
    {
        await _jSRuntime.InvokeVoidAsync(nameof(RemoveItem), key);
    }

    public async Task ClearItems()
    {
        await _jSRuntime.InvokeVoidAsync(nameof(ClearItems));
    }
}
