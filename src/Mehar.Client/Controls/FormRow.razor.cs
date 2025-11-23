using Microsoft.AspNetCore.Components;

namespace Mehar.Client.Controls;

public partial class FormRow
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}