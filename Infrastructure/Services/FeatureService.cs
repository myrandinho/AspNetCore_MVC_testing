

using Infrastructure.Factories;
using Infrastructure.Models;
using Infrastructure.Repositories;

namespace Infrastructure.Services;

public class FeatureService
{
    public readonly FeatureRepository _featureRepository;
    public readonly FeatureItemRepository _featureItemRepository;

    public async Task<ResponsResult> GetAllFeaturesAsync()
    {
        try
        {
            var result = await _featureRepository.GetAllAsync();
            return result;
        }
        catch (Exception ex) { return ResponseFactory.Error(ex.Message); }
    }
}
