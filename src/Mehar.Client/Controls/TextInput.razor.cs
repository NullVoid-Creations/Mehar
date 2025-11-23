using Microsoft.AspNetCore.Components;

namespace Mehar.Client.Controls;

public partial class TextInput<T>
{
    [Parameter]
    public string? Label { get; set; }

    [Parameter]
    public string? Watermark { get; set; }

    [Parameter]
    public string? HelpText { get; set; }

    [Parameter]
    public bool IsEnabled { get; set; } = true;

    [Parameter]
    public T? Value { get; set; }

    [Parameter]
    public EventCallback<T?> ValueChanged { get; set; }

    [Parameter]
    public string? BoxText { get; set; }
}