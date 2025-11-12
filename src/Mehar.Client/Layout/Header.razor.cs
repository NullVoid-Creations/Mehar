using Microsoft.AspNetCore.Components;

namespace Mehar.Client.Layout;

public partial class Header
{
    [Parameter]
    public bool IsDarkMode { get; set; }

    [Parameter]
    public EventCallback<bool> IsDarkModeChanged { get; set; }

    async Task ToggleDarkMode()
    {
        IsDarkMode = !IsDarkMode;
        await IsDarkModeChanged.InvokeAsync(IsDarkMode);
    }
}