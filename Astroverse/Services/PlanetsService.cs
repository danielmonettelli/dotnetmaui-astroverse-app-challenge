using Astroverse.Constants;
using Astroverse.Models;
using System.Net.Http.Json;

namespace Astroverse.Services;

public class PlanetsService : IPlanetsService
{
    private readonly HttpClient _httpClient;

    public PlanetsService()
    {
        _httpClient = new HttpClient();
    }

    public async Task<List<Planet>> GetPlanetsAsync()
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<List<Planet>>(APIConstants.APIMochaUrl);
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine("HTTP request error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Overall error: " + ex.Message);
        }

        return default;
    }

}
