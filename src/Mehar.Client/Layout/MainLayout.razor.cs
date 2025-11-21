
namespace Mehar.Client.Layout;

public partial class MainLayout
{
    bool IsDarkMode
    {
        get => field;
        set
        {
            if (value == field)
                return;

            field = value;
            InteropService.SetItem(nameof(IsDarkMode), field);
        }
    }

    protected override async Task OnInitializedAsync()
    {
        var isDarkMode = await InteropService.GetItem<bool?>(nameof(IsDarkMode));
        IsDarkMode = isDarkMode is null ?
            await InteropService.IsDarkMode() :
            isDarkMode.Value;
    }
}