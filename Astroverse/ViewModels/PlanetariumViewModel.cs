using Astroverse.Models;
using Astroverse.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Astroverse.ViewModels;

public partial class PlanetariumViewModel : BaseViewModel
{
    [ObservableProperty]
    private List<Planet> planets;

    private readonly IPlanetsService _planetsService;

    public PlanetariumViewModel(IPlanetsService planetsService)
    {
        _planetsService = planetsService;

        LoadPlanetsAsync();
    }

    private async Task LoadPlanetsAsync()
    {
        Planets = await _planetsService.GetPlanetsAsync();
    }

}
