namespace Malabanan_Portfolio.Models
{
    public class HeroModel
    {
        public string HeroName { get; set; } = string.Empty;
        public string HeroTitle { get; set; } = string.Empty;
        public string HeroDescription { get; set; } = string.Empty;
        public string HeroImage { get; set; } = string.Empty;

        public HeroModel(string heroName, string heroTitle, string heroDescription, string heroImage)
        {
            HeroName = heroName;
            HeroTitle = heroTitle;
            HeroDescription = heroDescription;
            HeroImage = heroImage;
        }
    }
}
