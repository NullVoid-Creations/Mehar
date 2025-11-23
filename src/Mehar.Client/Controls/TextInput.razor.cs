using Microsoft.AspNetCore.Components;

namespace Mehar.Client.Controls;

public partial class TextInput<T>
{
    [Parameter]
    public string? Watermark { get; set; }
}