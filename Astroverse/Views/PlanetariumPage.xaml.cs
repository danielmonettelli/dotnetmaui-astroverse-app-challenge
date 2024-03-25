using Astroverse.Services;
using Astroverse.ViewModels;

namespace Astroverse.Views;

public partial class PlanetariumPage : ContentPage
{
    readonly PlanetariumViewModel vm = new(new PlanetsService());

    public PlanetariumPage()
    {
        InitializeComponent();

        BindingContext = vm;
    }

}