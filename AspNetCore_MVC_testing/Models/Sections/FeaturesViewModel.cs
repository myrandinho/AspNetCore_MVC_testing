using AspNetCore_MVC_testing.Models.Components;

namespace AspNetCore_MVC_testing.Models.Sections;

public class FeaturesViewModel
{
    public string? Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }

    public List<FeaturesBoxViewModel>? FeaturesBoxes { get; set; }

    public FeaturesViewModel()
    {
        FeaturesBoxes = new List<FeaturesBoxViewModel>();
    }
}


