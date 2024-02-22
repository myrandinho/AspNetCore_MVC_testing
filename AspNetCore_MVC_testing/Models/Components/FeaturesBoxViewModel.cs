namespace AspNetCore_MVC_testing.Models.Components
{
    public class FeaturesBoxViewModel
    {
        public string? Id { get; set; }
        public List<string>? ClassNames { get; set; }
        public LinkViewModel? Link { get; set; }
        public ImageViewModel? Image { get; set; }
        public string? Topic { get; set; }
        public string? Text { get; set; }

        public FeaturesBoxViewModel()
        {
            ClassNames = new List<string>();
        }

    }
}
