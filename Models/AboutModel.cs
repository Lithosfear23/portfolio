namespace Malabanan_Portfolio.Models
{
    public class AboutModel
    {
        public List<string> DescriptionParagraphs { get; set; } = new();
        public List<string> Skills { get; set; } = new();

        public AboutModel(List<string> descriptionParagraphs, List<string> skills)
        {
            DescriptionParagraphs = descriptionParagraphs;
            Skills = skills;
        }
    }
}
