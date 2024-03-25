using Astroverse.ViewModels;

namespace Astroverse.Views;

public partial class WelcomePage : ContentPage
{
    readonly WelcomeViewModel vm = new();

    public WelcomePage()
    {
        InitializeComponent();

        BindingContext = vm;
    }
}