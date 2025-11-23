using Microsoft.AspNetCore.Components;

namespace Mehar.Client.Controls;

public partial class TextInput<T>
{
    [Parameter]
    public string Label { get; set; } = string.Empty;

    [Parameter]
    public string Placeholder {  get; set; } = string.Empty;

    [Parameter]
    public T? Value { get; set; }

    [Parameter]
    public EventCallback<T?> ValueChanged { get; set; }
}