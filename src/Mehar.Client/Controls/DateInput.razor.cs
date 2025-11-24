using Microsoft.AspNetCore.Components;

namespace Mehar.Client.Controls;

public partial class DateInput
{
    [Parameter]
    public string? Watermark { get; set; }

    [Parameter]
    public DateTime? MinDate { get; set; }

    [Parameter]
    public DateTime? MaxDate { get; set; }
}