using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Mehar.Client.Controls;

public partial class Form
{
    [Parameter]
    public string? Title { get; set; }

    [Parameter]
    public string? SubTitle { get; set; }

    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    [Parameter]
    public bool IsSaveEnabled { get; set; } = true;

    [Parameter]
    public EventCallback SaveClicked { get; set; }

    [Parameter]
    public bool IsResetEnabled { get; set; } = true;

    [Parameter]
    public EventCallback ResetClicked { get; set; }

    async void OnSaveClick(MouseEventArgs e)
    {
        await SaveClicked.InvokeAsync();
    }

    async void OnResetClick(MouseEventArgs e)
    {
        await ResetClicked.InvokeAsync();
    }
}