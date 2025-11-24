using Microsoft.AspNetCore.Components;

namespace Mehar.Client.Controls;

public partial class SelectInput<T>
{
    [Parameter]
    public string? Watermark { get; set; }

    [Parameter]
    public ICollection<T> Items { get; set; } = [];
}