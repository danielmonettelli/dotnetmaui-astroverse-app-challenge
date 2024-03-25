using Astroverse.Views;
using CommunityToolkit.Mvvm.Input;

namespace Astroverse.ViewModels;

public partial class WelcomeViewModel : BaseViewModel
{
    [RelayCommand]
    private async Task NextPage()
    {
        await Shell.Current.GoToAsync(
            state: nameof(PlanetariumPage),
            animate: true);
    }

}
