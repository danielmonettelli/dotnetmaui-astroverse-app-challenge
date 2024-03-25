using Astroverse.Models;

namespace Astroverse.Services;

public interface IPlanetsService
{
    Task<List<Planet>> GetPlanetsAsync();
}
